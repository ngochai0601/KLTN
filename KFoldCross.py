# sensitivity analysis of k in k-fold cross-validation
from numpy import mean
from sklearn.datasets import make_classification
from sklearn.model_selection import LeaveOneOut
from sklearn.model_selection import KFold
from sklearn.model_selection import StratifiedKFold
from sklearn.model_selection import cross_val_score
from sklearn.metrics import accuracy_score
from matplotlib import pyplot
import pickle
from sklearn.svm import SVC
import numpy as np

# create the dataset
def get_dataset():
    file = open("train_sv.pkl","rb")
    train = pickle.load(file)
    file.close()

    X,y = zip(*train)
    return X,y
################################################################
def get_model():
	model = SVC(kernel='rbf',C=100,gamma=0.01)
	# model = SVC(kernel='linear', C=1)
	return model

################################################################
def evaluate_model(cv):
	# get the dataset
	train, test = get_dataset()
	X = np.asarray(train)
	y = np.asarray(test)
	# get the model
	model = get_model()
	# evaluate the model
	scores = cross_val_score(model, X, y, scoring='accuracy', cv=cv, n_jobs=-1)
	# return scores
	return mean(scores), scores.min(), scores.max()

def train_model(X_train, X_test,y_train,y_test, fold_no):
	model = get_model()
	model.fit(X_train,y_train)
	predictions = model.predict(X_test)
	print('Fold',str(fold_no),'Accuracy:',accuracy_score(y_test,predictions))

skf = KFold(n_splits=3,shuffle=True, random_state=1)
fold_no = 1
train, test = get_dataset()
X = np.asarray(train)
y = np.asarray(test)
acc = list()

for train_ix, test_ix in skf.split(X, y):
	X_train, X_test = X[train_ix, :], X[test_ix, :]
	y_train, y_test = y[train_ix], y[test_ix]
	# train_model(X_train,X_test,y_train,y_test,fold_no)
	model = get_model()
	model.fit(X_train, y_train)
	predictions = model.predict(X_test)
	score=accuracy_score(y_test, predictions)
	acc.append(score)
	print('Fold' ,str(fold_no) ,'acc:',score)
	fold_no += 1
	
print('agr acc:',np.array(acc).mean())