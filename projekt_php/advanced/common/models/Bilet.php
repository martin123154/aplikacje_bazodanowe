<?php

namespace common\models;

use Yii;

/**
 * This is the model class for table "bilet".
 *
 * @property integer $id
 * @property string $cena
 * @property string $rodzaj
 * @property integer $rzad
 * @property integer $miejsce
 * @property integer $spektakl_id
 * @property integer $zakup_id
 *
 * @property Spektakl $spektakl
 * @property Zakup $zakup
 */
class Bilet extends \yii\db\ActiveRecord
{
    /**
     * @inheritdoc
     */
    public static function tableName()
    {
        return 'bilet';
    }

    /**
     * @inheritdoc
     */
    public function rules()
    {
        return [
            [['cena', 'rodzaj', 'rzad', 'miejsce', 'spektakl_id', 'zakup_id'], 'required'],
            [['cena'], 'number','min' => 0, 'max' => 10000],
            [['rzad', 'miejsce', 'spektakl_id', 'zakup_id'], 'integer', 'min' => 0, 'max' => 1000],
            [['rodzaj'], 'string', 'min' => 2,'max' => 255]
        ];
    }

    /**
     * @inheritdoc
     */
    public function attributeLabels()
    {
        return [
            'id' => Yii::t('app', 'ID'),
            'cena' => Yii::t('app', 'Cena'),
            'rodzaj' => Yii::t('app', 'Rodzaj'),
            'rzad' => Yii::t('app', 'Rzad'),
            'miejsce' => Yii::t('app', 'Miejsce'),
            'spektakl_id' => Yii::t('app', 'Spektakl ID'),
            'zakup_id' => Yii::t('app', 'Zakup ID'),
        ];
    }

    /**
     * @return \yii\db\ActiveQuery
     */
    public function getSpektakl()
    {
        return $this->hasOne(Spektakl::className(), ['id' => 'spektakl_id']);
    }

    /**
     * @return \yii\db\ActiveQuery
     */
    public function getZakup()
    {
        return $this->hasOne(Zakup::className(), ['id' => 'zakup_id']);
    }
}
