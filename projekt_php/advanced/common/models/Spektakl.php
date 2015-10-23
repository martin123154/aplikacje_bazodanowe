<?php

namespace common\models;

use Yii;

/**
 * This is the model class for table "spektakl".
 *
 * @property integer $id
 * @property string $tytul
 * @property string $data_rozp
 * @property string $data_zak
 *
 * @property Bilet[] $bilets
 * @property Wystep[] $wysteps
 */
class Spektakl extends \yii\db\ActiveRecord
{
    /**
     * @inheritdoc
     */
    public static function tableName()
    {
        return 'spektakl';
    }

    /**
     * @inheritdoc
     */
    public function rules()
    {
        return [
            [['tytul', 'data_rozp', 'data_zak'], 'required'],
            [['data_rozp', 'data_zak'], 'safe'],
            [['tytul'], 'string', 'min' => 2,'max' => 255],
			[['tytul'], 'unique'],
        ];
    }

    /**
     * @inheritdoc
     */
    public function attributeLabels()
    {
        return [
            'id' => Yii::t('app', 'ID'),
            'tytul' => Yii::t('app', 'Tytul przedstawienia'),
            'data_rozp' => Yii::t('app', 'Data rozpoczęcia'),
            'data_zak' => Yii::t('app', 'Data zakończenia'),
        ];
    }

    /**
     * @return \yii\db\ActiveQuery
     */
    public function getBilets()
    {
        return $this->hasMany(Bilet::className(), ['spektakl_id' => 'id']);
    }

    /**
     * @return \yii\db\ActiveQuery
     */
    public function getWysteps()
    {
        return $this->hasMany(Wystep::className(), ['spektakl_id' => 'id']);
    }
	

}
