<?php

use yii\helpers\Html;
use yii\widgets\ActiveForm;

/* @var $this yii\web\View */
/* @var $model common\models\Zakup */
/* @var $form yii\widgets\ActiveForm */
?>

<div class="zakup-form">

    <?php $form = ActiveForm::begin(); ?>

    <?= $form->field($model, 'data_zakupu')->textInput() ?>

    <?= $form->field($model, 'klient_id')->dropDownList($klient)  -> label('Klient') ?>

    <div class="form-group">
        <?= Html::submitButton($model->isNewRecord ? Yii::t('app', 'Dodaj') : Yii::t('app', 'Zmień'), ['class' => $model->isNewRecord ? 'btn btn-success' : 'btn btn-primary']) ?>
    </div>

    <?php ActiveForm::end(); ?>

</div>
