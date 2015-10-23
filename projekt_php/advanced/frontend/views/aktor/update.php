<?php

use yii\helpers\Html;

/* @var $this yii\web\View */
/* @var $model common\models\Aktor */

$this->title = Yii::t('app', 'Zmień {modelClass}: ', [
    'modelClass' => 'Aktor',
]) . ' ' . $model->Nazwisko;
$this->params['breadcrumbs'][] = ['label' => Yii::t('app', 'Aktor'), 'url' => ['index']];
$this->params['breadcrumbs'][] = ['label' => $model->Nazwisko, 'url' => ['view', 'id' => $model->Nazwisko]];
$this->params['breadcrumbs'][] = Yii::t('app', 'Zmień');
?>
<div class="aktor-update">

    <h1><?= Html::encode($this->title) ?></h1>

    <?= $this->render('_form', [
        'model' => $model,
    ]) ?>

</div>
