<?php

use yii\helpers\Html;


/* @var $this yii\web\View */
/* @var $model common\models\Bilet */

$this->title = Yii::t('app', 'Dodaj bilet');
$this->params['breadcrumbs'][] = ['label' => Yii::t('app', 'Bilet'), 'url' => ['index']];
$this->params['breadcrumbs'][] = $this->title;
?>
<div class="bilet-create">

    <h1><?= Html::encode($this->title) ?></h1>

    <?= $this->render('_form', [
        'model' => $model,
		'spektakl' => $spektakl,
		'zakup' => $zakup,
    ]) ?>

</div>
