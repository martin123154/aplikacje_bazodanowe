<?php

use yii\helpers\Html;


/* @var $this yii\web\View */
/* @var $model common\models\Zakup */

$this->title = Yii::t('app', 'Dodaj zakup');
$this->params['breadcrumbs'][] = ['label' => Yii::t('app', 'Zakup'), 'url' => ['index']];
$this->params['breadcrumbs'][] = $this->title;
?>
<div class="zakup-create">

    <h1><?= Html::encode($this->title) ?></h1>

    <?= $this->render('_form', [
        'model' => $model,
		'klient' => $klient,
    ]) ?>

</div>
