<?php

namespace frontend\controllers;

use Yii;
use common\models\Wystep;
use common\models\Aktor;
use common\models\Spektakl;
use common\models\WystepSearch;
use yii\web\Controller;
use yii\web\NotFoundHttpException;
use yii\filters\VerbFilter;
use yii\helpers\ArrayHelper;
use yii\filters\AccessControl;

/**
 * WystepController implements the CRUD actions for Wystep model.
 */
class WystepController extends Controller
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
     * Lists all Wystep models.
     * @return mixed
     */
    public function actionIndex()
    {
        $searchModel = new WystepSearch();
        $dataProvider = $searchModel->search(Yii::$app->request->queryParams);

        return $this->render('index', [
            'searchModel' => $searchModel,
            'dataProvider' => $dataProvider,
        ]);
    }

    /**
     * Displays a single Wystep model.
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
     * Creates a new Wystep model.
     * If creation is successful, the browser will be redirected to the 'view' page.
     * @return mixed
     */
    public function actionCreate()
    {
        $model = new Wystep();
		
		$aktor = Aktor::find()
		->orderBy('Nazwisko')
		->all();
		$spektakl = spektakl::find()
		->orderBy('tytul')
		->all();
		
		$aktor = ArrayHelper::map($aktor,'id','Nazwisko');
		$spektakl = ArrayHelper::map($spektakl,'id','tytul');
		
		
        if ($model->load(Yii::$app->request->post()) && $model->save()) {
            return $this->redirect(['view', 'id' => $model->id]);
        } else {
            return $this->render('create', [
                'model' => $model,
				'aktor' => $aktor,
		'spektakl' => $spektakl,
            ]);
        }
    }

    /**
     * Updates an existing Wystep model.
     * If update is successful, the browser will be redirected to the 'view' page.
     * @param integer $id
     * @return mixed
     */
    public function actionUpdate($id)
    {
        $model = $this->findModel($id);
		
			$aktor = Aktor::find()
		->orderBy('Nazwisko')
		->all();
		$spektakl = spektakl::find()
		->orderBy('tytul')
		->all();
		
		$aktor = ArrayHelper::map($aktor,'id','Nazwisko');
		$spektakl = ArrayHelper::map($spektakl,'id','tytul');

        if ($model->load(Yii::$app->request->post()) && $model->save()) {
            return $this->redirect(['view', 'id' => $model->id]);
        } else {
            return $this->render('update', [
                'model' => $model,
				'aktor' => $aktor,
		'spektakl' => $spektakl,
            ]);
        }
    }

    /**
     * Deletes an existing Wystep model.
     * If deletion is successful, the browser will be redirected to the 'index' page.
     * @param integer $id
     * @return mixed
     */
    public function actionDelete($id)
    {
        $this->findModel($id)->delete();

        return $this->redirect(['index']);
    }

    /**
     * Finds the Wystep model based on its primary key value.
     * If the model is not found, a 404 HTTP exception will be thrown.
     * @param integer $id
     * @return Wystep the loaded model
     * @throws NotFoundHttpException if the model cannot be found
     */
    protected function findModel($id)
    {
        if (($model = Wystep::findOne($id)) !== null) {
            return $model;
        } else {
            throw new NotFoundHttpException('The requested page does not exist.');
        }
    }
}
