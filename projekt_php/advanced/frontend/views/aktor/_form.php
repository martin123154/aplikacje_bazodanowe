<?php

use yii\helpers\Html;
use yii\widgets\ActiveForm;

/* @var $this yii\web\View */
/* @var $model common\models\Aktor */
/* @var $form yii\widgets\ActiveForm */
?>

<div class="aktor-form">

    <?php $form = ActiveForm::begin(); ?>

    <?= $form->field($model, 'imie')->textInput(['maxlength' => 255]) ?>

    <?= $form->field($model, 'nazwisko')->textInput(['maxlength' => 255]) ?>

    <?= $form->field($model, 'pesel')->textInput(['maxlength' => 11]) ?>

    <div class="form-group">
        <?= Html::submitButton($model->isNewRecord ? Yii::t('app', 'Dodaj') : Yii::t('app', 'Zmień'), ['class' => $model->isNewRecord ? 'btn btn-success' : 'btn btn-primary']) ?>
    </div>

    <?php ActiveForm::end(); ?>

</div>
