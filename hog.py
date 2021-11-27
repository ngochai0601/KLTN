import glob
from PIL import Image
import imutils
import cv2
from skimage.feature import hog
import pickle
import os
import random
import numpy as np
import matplotlib.pyplot as plt
from skimage import exposure
from mtcnn import MTCNN
import time
import pandas as pd
##########################Lưu file theo dạng nhị phân###########################
def saveBinary(path, obj):
    f = open(path, 'wb')
    pickle.dump(obj, f)
    f.close()
#####################Lưu file theo dạng text#####################################
def saveText(path, obj):
    data, labels= zip(*obj)
    with open(path, "w") as f:
        for idx in np.arange(len(data)):
            # if idx not in rand_idx:
            f.write(str(data[idx])+','+str(labels[idx]) + '\n')
##########################Xử lý ảnh lấy đặc trưng HOG###########################
def preprocessing(fileType):
    data = []
    labels = []
    timeProcess = 0;
    timeDetect = 0;
    for file in os.listdir(fileType):
            label,emotion,_ = file.split('.')
            pic_file =  os.path.join(fileType, file)
            filelist = glob.glob(pic_file)
            for fname in filelist:
                gray = np.array(Image.open(fname))
                img = cv2.cvtColor(gray, cv2.COLOR_GRAY2BGR)
                start = time.time()
                results = detect.detect_faces(img)
                timeDetect += (time.time()-start)
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


                # Khởi tạo HOG descriptor
                    start = time.time()
                    hogImage = hog(face, orientations=9, pixels_per_cell=(32, 32),
                                    cells_per_block=(4, 4), transform_sqrt=True, block_norm="L2",
                                    visualize=False)
                    timeProcess += (time.time()-start)
                # update the data and labels
                    data.append(hogImage)
                    labels.append(label)
    print("Time detect avg: ", timeDetect/np.array(data).shape[0])
    print("Time process avg: ", timeProcess/np.array(data).shape[0])
    c = list(zip(data, labels))
    random.shuffle(c)
    return c
###########################################################################
def process(fileType):
    data = []
    labels = []
    for folder in os.listdir(fileType):
        folder_path = os.path.join(fileType, folder)
        for file in os.listdir(folder_path):
            file_path = os.path.join(fileType, folder,file)
            img = cv2.imread(file_path)
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
                hogImage = hog(face, orientations=9, pixels_per_cell=(32, 32),
                               cells_per_block=(4, 4), transform_sqrt=True, block_norm="L2",
                               visualize=False)
                data.append(hogImage)
                labels.append(folder)

    c = list(zip(data, labels))
    random.shuffle(c)
    return c


detect = MTCNN()
c = process('../venv/face_data/train')
# data, labels = zip(*c)
saveBinary("train_sv.pkl",c)
# saveBinary("label.pkl",labels)
# saveText("train.txt",c)


