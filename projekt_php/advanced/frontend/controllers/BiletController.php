<?php

namespace frontend\controllers;

use Yii;
use common\models\Bilet;
use common\models\Spektakl;
use common\models\Zakup;
use common\models\BiletSearch;
use yii\web\Controller;
use yii\web\NotFoundHttpException;
use yii\filters\VerbFilter;
use yii\helpers\ArrayHelper;
use yii\filters\AccessControl;

/**
 * BiletController implements the CRUD actions for Bilet model.
 */
class BiletController extends Controller
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
     * Lists all Bilet models.
     * @return mixed
     */
    public function actionIndex()
    {
        $searchModel = new BiletSearch();
        $dataProvider = $searchModel->search(Yii::$app->request->queryParams);

        return $this->render('index', [
            'searchModel' => $searchModel,
            'dataProvider' => $dataProvider,
        ]);
    }

    /**
     * Displays a single Bilet model.
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
     * Creates a new Bilet model.
     * If creation is successful, the browser will be redirected to the 'view' page.
     * @return mixed
     */
    public function actionCreate()
    {
        $model = new Bilet();
		
		$spektakl = Spektakl::find()
		->orderBy('tytul')
		->all();
		$zakup = Zakup::find()
		->orderBy('data_zakupu')
		->all();
		
		$spektakl = ArrayHelper::map($spektakl,'id','tytul');
		$zakup = ArrayHelper::map($zakup,'id','data_zakupu');
		

        if ($model->load(Yii::$app->request->post()) && $model->save()) {
            return $this->redirect(['view', 'id' => $model->id]);
        } else {
            return $this->render('create', [
                'model' => $model,
				'spektakl' => $spektakl,
		'zakup' => $zakup,
            ]);
        }
    }

    /**
     * Updates an existing Bilet model.
     * If update is successful, the browser will be redirected to the 'view' page.
     * @param integer $id
     * @return mixed
     */
    public function actionUpdate($id)
    {
        $model = $this->findModel($id);
		$spektakl = Spektakl::find()
		->orderBy('tytul')
		->all();
		$zakup = Zakup::find()
		->orderBy('data_zakupu')
		->all();
		
		$spektakl = ArrayHelper::map($spektakl,'id','tytul');
		$zakup = ArrayHelper::map($zakup,'id','data_zakupu');
		

        if ($model->load(Yii::$app->request->post()) && $model->save()) {
            return $this->redirect(['view', 'id' => $model->id]);
        } else {
            return $this->render('update', [
                'model' => $model,
				'spektakl' => $spektakl,
		'zakup' => $zakup,
            ]);
        }
    }

    /**
     * Deletes an existing Bilet model.
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
     * Finds the Bilet model based on its primary key value.
     * If the model is not found, a 404 HTTP exception will be thrown.
     * @param integer $id
     * @return Bilet the loaded model
     * @throws NotFoundHttpException if the model cannot be found
     */
    protected function findModel($id)
    {
        if (($model = Bilet::findOne($id)) !== null) {
            return $model;
        } else {
            throw new NotFoundHttpException('The requested page does not exist.');
        }
    }
}
