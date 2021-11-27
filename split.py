import cv2
import os

def slipt(path_raw):
    for folder_raw in os.listdir(path_raw):
        os.mkdir(os.path.join('train', folder_raw))
        os.mkdir(os.path.join('test', folder_raw))
        folder_path = os.path.join(path_raw, folder_raw)
        dem = 0
        for file_raw in os.listdir(folder_path):
            file_path = os.path.join(folder_path, file_raw)
            img = cv2.imread(file_path)
            if(dem < len(os.listdir(folder_path))*0.2):

                cv2.imwrite(os.path.join('test',folder_raw , file_raw), img)
            else:
                try:
                    cv2.imwrite(os.path.join('train', folder_raw, file_raw), img)
                except:
                    dem = dem + 1
            dem = dem + 1

slipt('AnhSV')