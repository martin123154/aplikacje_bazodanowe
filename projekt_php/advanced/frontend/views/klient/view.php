<?php

use yii\helpers\Html;
use yii\widgets\DetailView;

/* @var $this yii\web\View */
/* @var $model common\models\Klient */

$this->title = $model->Nazwisko;
$this->params['breadcrumbs'][] = ['label' => Yii::t('app', 'Klient'), 'url' => ['index']];
$this->params['breadcrumbs'][] = $this->title;
?>
<div class="klient-view">

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
            'imie',
            'nazwisko',
            'pesel',
        ],
    ]) ?>

</div>
