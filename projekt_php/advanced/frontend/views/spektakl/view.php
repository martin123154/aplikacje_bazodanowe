<?php

use yii\helpers\Html;
use yii\widgets\DetailView;

/* @var $this yii\web\View */
/* @var $model common\models\Spektakl */

$this->title = $model->tytul;
$this->params['breadcrumbs'][] = ['label' => Yii::t('app', 'Premiera'), 'url' => ['index']];
$this->params['breadcrumbs'][] = $this->title;
?>
<div class="spektakl-view">

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
          //  'id',
            'tytul',
            'data_rozp',
            'data_zak',
        ],
    ]) ?>

</div>
