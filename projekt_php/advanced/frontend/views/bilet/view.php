<?php

use yii\helpers\Html;
use yii\widgets\DetailView;

/* @var $this yii\web\View */
/* @var $model common\models\Bilet */

$this->title = $model->rodzaj;
$this->params['breadcrumbs'][] = ['label' => Yii::t('app', 'Bilet'), 'url' => ['index']];
$this->params['breadcrumbs'][] = $this->title;
?>
<div class="bilet-view">

    <h1><?= Html::encode($this->title) ?></h1>

    <p>
        <?= Html::a(Yii::t('app', 'Zmień'), ['update', 'id' => $model->id], ['class' => 'btn btn-primary']) ?>
        <?= Html::a(Yii::t('app', 'Usuń'), ['delete', 'id' => $model->id], [
            'class' => 'btn btn-danger',
            'data' => [
                'confirm' => Yii::t('app', 'Jesteś pewny usunięcia?'),
                'method' => 'post',
            ],
        ]) ?>
    </p>

    <?= DetailView::widget([
        'model' => $model,
        'attributes' => [
           // 'id',
            'cena:currency',
            'rodzaj',
            'rzad',
            'miejsce',
            'spektakl.tytul',
            'zakup.data_zakupu',
        ],
    ]) ?>

</div>
