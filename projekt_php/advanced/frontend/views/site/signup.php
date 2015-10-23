<?php
use yii\helpers\Html;
use yii\bootstrap\ActiveForm;

/* @var $this yii\web\View */
/* @var $form yii\bootstrap\ActiveForm */
/* @var $model \frontend\models\SignupForm */

$this->title = 'Rejestracja';
$this->params['breadcrumbs'][] = $this->title;
?>
<div class="site-signup">
    <h1><?= Html::encode($this->title) ?></h1>

    <p>Prosze o wypełnienie poniższych pól:</p>

    <div class="row">
        <div class="col-lg-5">
            <?php $form = ActiveForm::begin(['id' => 'form-signup']); ?>
                <?= $form->field($model, 'username') -> label('Użytkownik')?>
                <?= $form->field($model, 'email') -> label('Email')?>
                <?= $form->field($model, 'password')->passwordInput() -> label('Hasło')?>
                <div class="form-group">
                    <?= Html::submitButton('Rejestruj', ['class' => 'btn btn-primary', 'name' => 'signup-button'])  ?>
                </div>
            <?php ActiveForm::end(); ?>
        </div>
    </div>
</div>
