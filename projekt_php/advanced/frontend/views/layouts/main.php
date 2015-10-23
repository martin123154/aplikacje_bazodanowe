<?php
use yii\helpers\Html;
use yii\bootstrap\Nav;
use yii\bootstrap\NavBar;
use yii\widgets\Breadcrumbs;
use frontend\assets\AppAsset;
use frontend\widgets\Alert;

/* @var $this \yii\web\View */
/* @var $content string */

AppAsset::register($this);
?>
<?php $this->beginPage() ?>
<!DOCTYPE html>
<html lang="<?= Yii::$app->language ?>">
<head>
    <meta charset="<?= Yii::$app->charset ?>">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <?= Html::csrfMetaTags() ?>
    <title><?= Html::encode($this->title) ?></title>
    <?php $this->head() ?>
</head>
<body>
    <?php $this->beginBody() ?>
    <div class="wrap">
	
        <?php
            NavBar::begin([
                'brandLabel' => 'Mój Projekt PHP',
                'brandUrl' => Yii::$app->homeUrl,
                'options' => [
                    'class' => 'navbar-inverse navbar-fixed-top',
                ],
            ]);
            $menuItems = [
			
                ['label' => 'Główna', 'url' => ['/site/index']],
				
				['label' => 'Tabele', 'items' => [
					  ['label' => 'Klient', 'url' => ['/klient/index']],
					  ['label' => 'Zakup', 'url' => ['/zakup/index']],
					  ['label' => 'Bilet', 'url' => ['/bilet/index']],
					  ['label' => 'Premiera', 'url' => ['/spektakl/index']],
					  ['label' => 'Aktor', 'url' => ['/aktor/index']],
					  ['label' => 'Wystep', 'url' => ['/wystep/index']],
					
					]],
				
                ['label' => 'O mnie', 'url' => ['/site/about']],
             //   ['label' => 'Kontakt', 'url' => ['/site/contact']],
            ];
            if (Yii::$app->user->isGuest) {
                $menuItems[] = ['label' => 'Rejestracja', 'url' => ['/site/signup']];
                $menuItems[] = ['label' => 'Logowanie', 'url' => ['/site/login']];
            } else {
                $menuItems[] = [
                    'label' => 'Logout (' . Yii::$app->user->identity->username . ')',
                    'url' => ['/site/logout'],
                    'linkOptions' => ['data-method' => 'post']
                ];
            }
            echo Nav::widget([
                'options' => ['class' => 'navbar-nav navbar-right'],
                'items' => $menuItems,
            ]);
            NavBar::end();
        ?>

        <div class="container">
        <?= Breadcrumbs::widget([
            'links' => isset($this->params['breadcrumbs']) ? $this->params['breadcrumbs'] : [],
        ]) ?>
        <?= Alert::widget() ?>
        <?= $content ?>
        </div>
    </div>

    

    <?php $this->endBody() ?>
</body>
</html>
<?php $this->endPage() ?>
