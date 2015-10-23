<?php

use yii\helpers\Html;
use yii\widgets\ActiveForm;

/* @var $this yii\web\View */
/* @var $model common\models\Spektakl */
/* @var $form yii\widgets\ActiveForm */
?>

<div class="spektakl-form">

    <?php $form = ActiveForm::begin(); ?>

    <?= $form->field($model, 'tytul')->textInput(['maxlength' => 255]) ?>

    <?= $form->field($model, 'data_rozp')->textInput() ?>

    <?= $form->field($model, 'data_zak')->textInput() ?>

    <div class="form-group">
        <?= Html::submitButton($model->isNewRecord ? Yii::t('app', 'Dodaj') : Yii::t('app', 'Zmień'), ['class' => $model->isNewRecord ? 'btn btn-success' : 'btn btn-primary']) ?>
    </div>

    <?php ActiveForm::end(); ?>

</div>
