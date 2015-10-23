<?php

namespace common\models;

use Yii;

/**
 * This is the model class for table "wystep".
 *
 * @property integer $aktor_id
 * @property integer $spektakl_id
 *
 * @property Spektakl $spektakl
 * @property Aktor $aktor
 */
class Wystep extends \yii\db\ActiveRecord
{
    /**
     * @inheritdoc
     */
    public static function tableName()
    {
        return 'wystep';
    }

    /**
     * @inheritdoc
     */
    public function rules()
    {
        return [
            [['aktor_id', 'spektakl_id'], 'required'],
            [['aktor_id', 'spektakl_id'], 'integer']
        ];
    }

    /**
     * @inheritdoc
     */
    public function attributeLabels()
    {
        return [
            'aktor_id' => Yii::t('app', 'Aktor ID'),
            'spektakl_id' => Yii::t('app', 'Spektakl ID'),
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
    public function getAktor()
    {
        return $this->hasOne(Aktor::className(), ['id' => 'aktor_id']);
    }
	

}
