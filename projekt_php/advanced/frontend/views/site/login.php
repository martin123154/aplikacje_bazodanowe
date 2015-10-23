<?php
use yii\helpers\Html;
use yii\bootstrap\ActiveForm;

/* @var $this yii\web\View */
/* @var $form yii\bootstrap\ActiveForm */
/* @var $model \common\models\LoginForm */

$this->title = 'Logowanie';
$this->params['breadcrumbs'][] = $this->title;
?>
<div class="site-login">
    <h1><?= Html::encode($this->title) ?></h1>

    <p>Wypełnij poniższe pola :</p>

    <div class="row">
        <div class="col-lg-5">
            <?php $form = ActiveForm::begin(['id' => 'login-form']); ?>
                <?= $form->field($model, 'username') -> label('Użytkownik')?>
                <?= $form->field($model, 'password')->passwordInput() -> label('Hasło') ?>
                <?= $form->field($model, 'rememberMe')->checkbox() -> label('Zapamiętaj') ?>
                <div style="color:#999;margin:1em 0">
                   Jeżeli zapomniałeś hasła możesz je  <?= Html::a('zresetować', ['site/request-password-reset']) ?>.
                </div>
                <div class="form-group">
                    <?= Html::submitButton('Loguj', ['class' => 'btn btn-primary', 'name' => 'login-button']) ?>
                </div>
            <?php ActiveForm::end(); ?>
        </div>
    </div>
</div>
