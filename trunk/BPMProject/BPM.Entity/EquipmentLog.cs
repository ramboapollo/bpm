// File:    EquipmentLog.cs
// Author:  Administrator
// Created: 2015��5��19�� 22:15:45
// Purpose: Definition of Class EquipmentLog

using System;

using ServiceStack.DataAnnotations;
/// �豸�䶯��Ϣ��
public class EquipmentLog
{
   ///<summary>
   ///��־Id
   ///</summary>
    [AutoIncrement]
   public long id {get;set;}
   ///<summary>
   ///�豸����
   ///</summary>
   public long equipmentId {get;set;}
   ///<summary>
   ///������
   ///</summary>
   public string userName {get;set;}
   ///<summary>
   ///ʱ��
   ///</summary>
   public DateTime time {get;set;}
   ///<summary>
   ///��¼����
   ///</summary>
   public string recordType {get;set;}
   ///<summary>
   ///��ע
   ///</summary>
   public string remarks {get;set;}

}