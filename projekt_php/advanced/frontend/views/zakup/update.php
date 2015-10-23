<?php

use yii\helpers\Html;

/* @var $this yii\web\View */
/* @var $model common\models\Zakup */

$this->title = Yii::t('app', 'Zmień {modelClass}: ', [
    'modelClass' => 'Zakup',
]) . ' ' . $model->data_zakupu;
$this->params['breadcrumbs'][] = ['label' => Yii::t('app', 'Zakup'), 'url' => ['index']];
$this->params['breadcrumbs'][] = ['label' => $model->data_zakupu, 'url' => ['view', 'id' => $model->data_zakupu]];
$this->params['breadcrumbs'][] = Yii::t('app', 'Zmień');
?>
<div class="zakup-update">

    <h1><?= Html::encode($this->title) ?></h1>

    <?= $this->render('_form', [
        'model' => $model,
		'klient' => $klient,
    ]) ?>

</div>
