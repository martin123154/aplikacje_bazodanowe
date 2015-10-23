<?php
return [
    'vendorPath' => dirname(dirname(__DIR__)) . '/vendor',
	'language' => 'pl',
    'components' => [
		'formatter' => [
      'decimalSeparator' => ',',
        'thousandSeparator' => ' ',
        'currencyCode' => 'PLN',
       
   ],
	
        'cache' => [
            'class' => 'yii\caching\FileCache',
        ],
    ],
];
