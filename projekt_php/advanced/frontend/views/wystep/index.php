<?php

use yii\helpers\Html;
use yii\grid\GridView;

/* @var $this yii\web\View */
/* @var $searchModel common\models\WystepSearch */
/* @var $dataProvider yii\data\ActiveDataProvider */

$this->title = Yii::t('app', 'Wystep');
$this->params['breadcrumbs'][] = $this->title;
?>
<div class="wystep-index">

    <h1><?= Html::encode($this->title) ?></h1>
    <?php // echo $this->render('_search', ['model' => $searchModel]); ?>

    <p>
        <?= Html::a(Yii::t('app', 'Dodaj występ'), ['create'], ['class' => 'btn btn-success']) ?>
    </p>

    <?= GridView::widget([
        'dataProvider' => $dataProvider,
        'filterModel' => $searchModel,
        'columns' => [
            ['class' => 'yii\grid\SerialColumn'],

           // 'id',
            [ 'attribute' => 'aktor.imie',
			'label' => 'Imię aktora',
                'filter' => Html::activeTextInput($searchModel, 'aktor_imie', ['class' => 'form-control']),],
			[ 'attribute' => 'aktor.nazwisko',
			'label' => 'Nazwisko aktora',
                'filter' => Html::activeTextInput($searchModel, 'aktor_nazwisko', ['class' => 'form-control']),],
            [ 'attribute' => 'spektakl.tytul',
                'filter' => Html::activeTextInput($searchModel, 'spektakl_tytul', ['class' => 'form-control']),],

			//'spektakl.data_rozp:text: Data rozpoczęcia',

            ['class' => 'yii\grid\ActionColumn'],
        ],
    ]); ?>

</div>
