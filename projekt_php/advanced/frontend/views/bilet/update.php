<?php

use yii\helpers\Html;

/* @var $this yii\web\View */
/* @var $model common\models\Bilet */

$this->title = Yii::t('app', 'Zmień {modelClass}: ', [
    'modelClass' => 'Bilet',
]) . ' ' . $model->rodzaj;
$this->params['breadcrumbs'][] = ['label' => Yii::t('app', 'Bilet'), 'url' => ['index']];
$this->params['breadcrumbs'][] = ['label' => $model->rodzaj, 'url' => ['view', 'id' => $model->rodzaj]];
$this->params['breadcrumbs'][] = Yii::t('app', 'Zmień');
?>
<div class="bilet-update">

    <h1><?= Html::encode($this->title) ?></h1>

    <?= $this->render('_form', [
        'model' => $model,
		'spektakl' => $spektakl,
		'zakup' => $zakup,
    ]) ?>

</div>
