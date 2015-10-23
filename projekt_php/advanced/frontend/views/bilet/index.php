<?php

use yii\helpers\Html;
use yii\grid\GridView;

/* @var $this yii\web\View */
/* @var $searchModel common\models\BiletSearch */
/* @var $dataProvider yii\data\ActiveDataProvider */

$this->title = Yii::t('app', 'Bilet');
$this->params['breadcrumbs'][] = $this->title;
?>
<div class="bilet-index">

    <h1><?= Html::encode($this->title) ?></h1>
    <?php // echo $this->render('_search', ['model' => $searchModel]); ?>

    <p>
        <?= Html::a(Yii::t('app', 'Dodaj bilet'), ['create'], ['class' => 'btn btn-success']) ?>
    </p>

    <?= GridView::widget([
        'dataProvider' => $dataProvider,
        'filterModel' => $searchModel,
        'columns' => [
            ['class' => 'yii\grid\SerialColumn'],

           // 'id',
            'cena:currency',
            'rodzaj',
            'rzad',
            'miejsce',
            
            [ 'attribute' => 'zakup.data_zakupu',
                'filter' => Html::activeTextInput($searchModel, 'zakup_data_zakupu', ['class' => 'form-control']),],
			[ 'attribute' => 'spektakl.tytul',
                'filter' => Html::activeTextInput($searchModel, 'spektakl_tytul', ['class' => 'form-control']),],
			[ 'attribute' => 'spektakl.data_rozp',
                'filter' => Html::activeTextInput($searchModel, 'spektakl_data_rozp', ['class' => 'form-control']),],

            ['class' => 'yii\grid\ActionColumn'],
        ],
    ]); ?>

</div>
