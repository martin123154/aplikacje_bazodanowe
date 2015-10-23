<?php

use yii\helpers\Html;

/* @var $this yii\web\View */
/* @var $model common\models\Spektakl */

$this->title = Yii::t('app', 'Zmień {modelClass}: ', [
    'modelClass' => 'Premiera',
]) . ' ' . $model->tytul;
$this->params['breadcrumbs'][] = ['label' => Yii::t('app', 'Premiera'), 'url' => ['index']];
$this->params['breadcrumbs'][] = ['label' => $model->tytul, 'url' => ['view', 'id' => $model->tytul]];
$this->params['breadcrumbs'][] = Yii::t('app', 'Zmień');
?>
<div class="spektakl-update">

    <h1><?= Html::encode($this->title) ?></h1>

    <?= $this->render('_form', [
        'model' => $model,
    ]) ?>

</div>
