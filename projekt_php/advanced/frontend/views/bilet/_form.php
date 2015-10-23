<?php

use yii\helpers\Html;
use yii\widgets\ActiveForm;

/* @var $this yii\web\View */
/* @var $model common\models\Bilet */
/* @var $form yii\widgets\ActiveForm */
?>

<div class="bilet-form">

    <?php $form = ActiveForm::begin(); ?>

    <?= $form->field($model, 'cena')->textInput(['maxlength' => 8]) ?>

    <?= $form->field($model, 'rodzaj')->textInput(['maxlength' => 255]) ?>

    <?= $form->field($model, 'rzad')->textInput() ?>

    <?= $form->field($model, 'miejsce')->textInput() ?>

    <?= $form->field($model, 'spektakl_id')->dropDownList($spektakl)  -> label('Tytuł spektaklu')?>

    <?= $form->field($model, 'zakup_id')->dropDownList($zakup)  -> label('Data zakupu') ?>

    <div class="form-group">
        <?= Html::submitButton($model->isNewRecord ? Yii::t('app', 'Dodaj') : Yii::t('app', 'Zmień'), ['class' => $model->isNewRecord ? 'btn btn-success' : 'btn btn-primary']) ?>
    </div>

    <?php ActiveForm::end(); ?>

</div>
