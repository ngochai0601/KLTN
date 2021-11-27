import pickle
import cv2
import numpy as np
from sklearn import svm
from sklearn.metrics import accuracy_score
from sklearn.model_selection import GridSearchCV
from sklearn.metrics import classification_report, confusion_matrix
from sklearn.datasets import load_breast_cancer
from sklearn.model_selection import train_test_split
from sklearn.model_selection import KFold

file = open("train_sv.pkl","rb")
train_list = pickle.load(file)
file.close()

file = open("test_sv.pkl","rb")
test_list = pickle.load(file)
file.close()
X_train, y_train  = zip(*train_list)
X_val, y_val  = zip(*test_list)


#############################Chia tập train tập test######################
# X_train, X_val, y_train, y_val = train_test_split(Feature_list, label_list, test_size=0.2, random_state=0)
#########################################################################
model=svm.SVC(kernel='linear',C=1)
model.fit(X_train,y_train) #train
y_pred = model.predict(X_val)
print("Accuracy: %.2f %%" %(100*accuracy_score(y_val, y_pred)))
print(classification_report(y_val, y_pred))
# result =model.predict([X_val[3]])
# print("KQ:",result,"Giá trị thực",y_val[3])
###########################################################################
# param_grid = [
#     {"kernel": ["rbf"], "gamma": [1e-2, 1e-3, 1e-4], "C": [0.1, 1, 10, 100]},
#     {"kernel": ["linear"], "C": [0.01, 0.1, 1, 10, 100]},
#     {"kernel": ["poly"], "degree": [3, 5, 7, 9]}, ]
# cv = KFold(n_splits=20, shuffle=True, random_state=1)
# grid = GridSearchCV(svm.SVC(), param_grid, refit=True, verbose=3, cv=cv)
# grid.fit(X_train, y_train)
# print(grid.best_params_)
# print(grid.best_estimator_)
# grid_predictions = grid.predict(X_val)
# print(classification_report(y_val, grid_predictions))


def saveBinary(path, obj):
    f = open(path, 'wb')
    pickle.dump(obj, f)
    f.close()

saveBinary("model.pkl",model)