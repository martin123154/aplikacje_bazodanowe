<?php

use yii\helpers\Html;
use yii\widgets\ActiveForm;

/* @var $this yii\web\View */
/* @var $model common\models\Wystep */
/* @var $form yii\widgets\ActiveForm */
?>

<div class="wystep-form">

    <?php $form = ActiveForm::begin(); ?>

    <?= $form->field($model, 'aktor_id')->dropDownList($aktor)  -> label('Aktor')?>

    <?= $form->field($model, 'spektakl_id')->dropDownList($spektakl)  -> label('Tytuł przedstawienia') ?>

    <div class="form-group">
        <?= Html::submitButton($model->isNewRecord ? Yii::t('app', 'Dodaj') : Yii::t('app', 'Zmień'), ['class' => $model->isNewRecord ? 'btn btn-success' : 'btn btn-primary']) ?>
    </div>

    <?php ActiveForm::end(); ?>

</div>
