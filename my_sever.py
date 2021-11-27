from flask import Flask
from flask_cors import CORS,cross_origin
from flask import request, jsonify
import numpy as np
import base64
import cv2
from mtcnn import MTCNN
import imutils
from skimage.feature import hog
from skimage import exposure
import pickle
from sklearn import svm
from PIL import Image
from base64 import decodestring
import io
import json
import os

#Khởi tạo Flask sever
app = Flask(__name__)
app.config['UPLOAD_FOLDER'] = "img"
#Apply Flask CORS
CORS(app)
#Nhận diện khuôn mặt
def DetectFace(img):
    detect = MTCNN()
    results = detect.detect_faces(img)
    if len(results) > 0:
        result = results[0]
        # lấy toạ độ khuôn mặt
        x1, y1, width, height = result['box']
        x1, y1 = abs(x1), abs(y1)
        x2 = x1 + width
        y2 = y1 + height
        face = img[y1:y2, x1:x2]
        face = cv2.cvtColor(face, cv2.COLOR_BGR2GRAY)
        face = cv2.resize(face, (256, 256))
        return face
#Rút trích đặc trưng
def FeatureExtraction(img):
    feature =[]
    hogImage = hog(img, orientations=9, pixels_per_cell=(32, 32),
                   cells_per_block=(4, 4), transform_sqrt=True, block_norm="L2",
                   visualize=False)
    feature.append(hogImage)
    return feature
f = open("model.pkl", 'rb')
model = pickle.load(f)
f.close()
#Nhận dạng gương mặt
def RecognitionFace(feature):
    result = model.predict(feature)
    return result

@app.route('/detect', methods=['POST'])
@cross_origin()
def process():
    image_b64 = request.form.get('image')
    image = np.frombuffer(base64.b64decode(image_b64), dtype=np.uint8)
    image = cv2.imdecode(image, cv2.IMREAD_COLOR)
    face = DetectFace(image)
    feature = FeatureExtraction(face)
    predict = RecognitionFace(feature)
    print(predict)
    return str(predict[0])
@app.route('/home')
def home():
    return "Phần mềm nhận dạng sinh viên"
#start
if __name__ == "__main__":
    app.run(host="0.0.0.0", port='8080')
