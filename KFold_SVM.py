from numpy import mean
from numpy import std
from numpy import isnan
from numpy import asarray
from numpy import polyfit
from scipy.stats import pearsonr
from matplotlib import pyplot
from sklearn.model_selection import KFold
from sklearn.model_selection import StratifiedKFold
from sklearn.svm import SVC
import pickle
from sklearn.model_selection import GridSearchCV
from sklearn.model_selection import cross_val_score
from sklearn.model_selection import LeaveOneOut
from sklearn.metrics import accuracy_score
import numpy as np

def get_dataset():
    file = open("train_sv.pkl","rb")
    train = pickle.load(file)
    file.close()

    X,y = zip(*train)
    return X,y
################################################################
def get_model():
	model = SVC(kernel='linear',C=1)
	return model

################################################################
train,test = get_dataset()
X = np.asarray(train)
y = np.asarray(test)
kfold = KFold(n_splits=10, shuffle=True, random_state=1)
outer_results = list()
###############################################################
for train_ix, test_ix in kfold.split(X):
	# split data
	X_train, X_test = X[train_ix, :], X[test_ix, :]
	y_train, y_test = y[train_ix], y[test_ix]
	# define the model
	model = SVC()
	cv_in = KFold(n_splits=3, shuffle=True, random_state=1)
	# define search param
	param_grid = [
	{"kernel": ["rbf"], "gamma": [1e-2,1e-3,1e-4], "C": [0.1,1, 10, 100]},
	{"kernel": ["linear"], "C": [0.01,0.1,1, 10, 100]},
	{"kernel": ["poly"], "degree": [3,5, 7,9]}]
    # define search
	search = GridSearchCV(model, param_grid,cv=cv_in, scoring='accuracy', refit=True)
	# execute search
	result = search.fit(X_train, y_train)
	# get the best performing model fit on the whole training set
	best_model = result.best_estimator_
	# evaluate model on the hold out dataset
	yhat = best_model.predict(X_test)
	# evaluate the model
	acc = accuracy_score(y_test, yhat)
	# store the result
	outer_results.append(acc)
	# report progress
	print('>acc=%.3f, est=%.3f, cfg=%s' % (acc, result.best_score_, result.best_params_))
# summarize the estimated performance of the model
print('Accuracy: %.3f (%.3f)' % (mean(outer_results), std(outer_results)))
