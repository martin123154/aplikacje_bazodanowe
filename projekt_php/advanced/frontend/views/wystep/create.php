<?php

use yii\helpers\Html;


/* @var $this yii\web\View */
/* @var $model common\models\Wystep */

$this->title = Yii::t('app', 'Dodaj występ');
$this->params['breadcrumbs'][] = ['label' => Yii::t('app', 'Wystep'), 'url' => ['index']];
$this->params['breadcrumbs'][] = $this->title;
?>
<div class="wystep-create">

    <h1><?= Html::encode($this->title) ?></h1>

    <?= $this->render('_form', [
        'model' => $model,
		'aktor' => $aktor,
		'spektakl' => $spektakl,
    ]) ?>

</div>
