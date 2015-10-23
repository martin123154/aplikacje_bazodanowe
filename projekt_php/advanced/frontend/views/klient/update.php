<?php

use yii\helpers\Html;

/* @var $this yii\web\View */
/* @var $model common\models\Klient */

$this->title = Yii::t('app', 'Zmień {modelClass}: ', [
    'modelClass' => 'Klient',
]) . ' ' . $model->Nazwisko;
$this->params['breadcrumbs'][] = ['label' => Yii::t('app', 'Klient'), 'url' => ['index']];
$this->params['breadcrumbs'][] = ['label' => $model->Nazwisko, 'url' => ['view', 'id' => $model->Nazwisko]];
$this->params['breadcrumbs'][] = Yii::t('app', 'Zmień');
?>
<div class="klient-update">

    <h1><?= Html::encode($this->title) ?></h1>

    <?= $this->render('_form', [
        'model' => $model,
    ]) ?>

</div>
