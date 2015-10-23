<?php

use yii\helpers\Html;


/* @var $this yii\web\View */
/* @var $model common\models\Aktor */

$this->title = Yii::t('app', 'Dodaj aktora');
$this->params['breadcrumbs'][] = ['label' => Yii::t('app', 'Aktor'), 'url' => ['index']];
$this->params['breadcrumbs'][] = $this->title;
?>
<div class="aktor-create">

    <h1><?= Html::encode($this->title) ?></h1>

    <?= $this->render('_form', [
        'model' => $model,
    ]) ?>

</div>
