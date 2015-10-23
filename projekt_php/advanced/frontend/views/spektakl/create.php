<?php

use yii\helpers\Html;


/* @var $this yii\web\View */
/* @var $model common\models\Spektakl */

$this->title = Yii::t('app', 'Dodaj premiere');
$this->params['breadcrumbs'][] = ['label' => Yii::t('app', 'Premiera'), 'url' => ['index']];
$this->params['breadcrumbs'][] = $this->title;
?>
<div class="spektakl-create">

    <h1><?= Html::encode($this->title) ?></h1>

    <?= $this->render('_form', [
        'model' => $model,
    ]) ?>

</div>
