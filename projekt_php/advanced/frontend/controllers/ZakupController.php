<?php

namespace frontend\controllers;

use Yii;
use common\models\Zakup;
use common\models\Klient;
use common\models\ZakupSearch;
use yii\web\Controller;
use yii\web\NotFoundHttpException;
use yii\filters\VerbFilter;
use yii\helpers\ArrayHelper;
use yii\filters\AccessControl;

/**
 * ZakupController implements the CRUD actions for Zakup model.
 */
class ZakupController extends Controller
{
    public function behaviors()
    {
        return [
            'access' => [
                'class' => AccessControl::className(),
                'rules' => [
                    [
                        'allow' => true,
                        'actions' => ['index', 'create', 'update', 'delete', 'view'],
                        'roles' => ['@'], // @ - uzytkownicy zalogowani, ? - uzytkownicy niezalogowani
                    ],
                ],
            ],
			];
    }

    /**
     * Lists all Zakup models.
     * @return mixed
     */
    public function actionIndex()
    {
        $searchModel = new ZakupSearch();
        $dataProvider = $searchModel->search(Yii::$app->request->queryParams);

        return $this->render('index', [
            'searchModel' => $searchModel,
            'dataProvider' => $dataProvider,
        ]);
    }

    /**
     * Displays a single Zakup model.
     * @param integer $id
     * @return mixed
     */
    public function actionView($id)
    {
        return $this->render('view', [
            'model' => $this->findModel($id),
        ]);
    }

    /**
     * Creates a new Zakup model.
     * If creation is successful, the browser will be redirected to the 'view' page.
     * @return mixed
     */
    public function actionCreate()
    {
        $model = new Zakup();
		
		$klient = Klient::find()
		->orderBy('Nazwisko')
		->all();
		
		
		$klient = ArrayHelper::map($klient,'id','Nazwisko');
	

        if ($model->load(Yii::$app->request->post()) && $model->save()) {
            return $this->redirect(['view', 'id' => $model->id]);
        } else {
            return $this->render('create', [
                'model' => $model,
				'klient' => $klient,
            ]);
        }
    }

    /**
     * Updates an existing Zakup model.
     * If update is successful, the browser will be redirected to the 'view' page.
     * @param integer $id
     * @return mixed
     */
    public function actionUpdate($id)
    {
        $model = $this->findModel($id);

		$klient = Klient::find()
		->orderBy('Nazwisko')
		->all();
		
		
		$klient = ArrayHelper::map($klient,'id','Nazwisko');
        if ($model->load(Yii::$app->request->post()) && $model->save()) {
            return $this->redirect(['view', 'id' => $model->id]);
        } else {
            return $this->render('update', [
                'model' => $model,
				'klient' => $klient,
            ]);
        }
    }

    /**
     * Deletes an existing Zakup model.
     * If deletion is successful, the browser will be redirected to the 'index' page.
     * @param integer $id
     * @return mixed
     */
        public function actionDelete($id)
    {
        $model = $this->findModel($id);
        try{
            $model->delete();
            return $this->redirect(['index']);
        }catch(\Exception $ex){
            Yii::$app->getSession()->setFlash('error', 'Nie można usunąć z powodu powiązania z inną tabelą');
        }
        return $this->goBack();
    }

    /**
     * Finds the Zakup model based on its primary key value.
     * If the model is not found, a 404 HTTP exception will be thrown.
     * @param integer $id
     * @return Zakup the loaded model
     * @throws NotFoundHttpException if the model cannot be found
     */
    protected function findModel($id)
    {
        if (($model = Zakup::findOne($id)) !== null) {
            return $model;
        } else {
            throw new NotFoundHttpException('The requested page does not exist.');
        }
    }
}
