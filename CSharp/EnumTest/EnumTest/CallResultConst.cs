
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumTest
{
    public class CallResultConst
    {

        private static bool register = false;
        private static Object LockObject = new object();
        public static void RegisterDescription()
        {
            if (!register)
            {
                lock (LockObject)
                {
                    if (!register)
                    {
                        //jinxingzhuce
                        Type type = typeof(CallResultConst);
                        var fields = type.GetFields();
                        foreach (var t in fields)
                        {
                            if (t != null)
                            {
                                var des = Attribute.GetCustomAttribute(t, typeof(DescriptionAttribute)) as DescriptionAttribute;
                                string str = t.Name;
                                if (des != null)
                                {
                                    str = des.Description;
                                }
                                EnumDescription.Add((CallResult)(t.GetValue(type)), str);
                            }
                        }
                        register = true;
                    }
                }
            }
        }
        [Description("标签已使用！")]
        public static CallResult RFIDTAGUSED = CallResult.Max + 1;
        //{
        //    get
        //    {
        //        RegisterDescription();
        //        return CallResult.Max + 1;
        //    }
        //}
        [Description("非法标签！")]
        public const CallResult ILlegeTag = CallResult.Max + 2;
        [Description("没有主配件")]
        public const CallResult NOMAINDEVICE = CallResult.Max + 3;
        [Description("存在多个主配件")]
        public const CallResult HASMOREMAINDEVICE = CallResult.Max + 4;

        [Description("保存成功")]
        public const CallResult SaveSuccess = CallResult.Max + 5;
        [Description("保存失败")]
        public const CallResult SaveFail = CallResult.Max + 6;
        [Description("添加成功")]
        public const CallResult AddSuccess = CallResult.Max + 7;
        [Description("添加失败")]
        public const CallResult AddFail = CallResult.Max + 8;
        [Description("删除成功")]
        public const CallResult DeleteSuccess = CallResult.Max + 9;
        [Description("删除失败")]
        public const CallResult DeleteFail = CallResult.Max + 10;
        [Description("操作成功")]
        public const CallResult OperateSuccess = CallResult.Max + 11;
        [Description("操作失败")]
        public const CallResult OperateFail = CallResult.Max + 12;
        [Description("提交失败")]
        public const CallResult SubmitFail = CallResult.Max + 13;
        [Description("提交成功")]
        public const CallResult SubmitSuccess = CallResult.Max + 14;

        [Description("设备编号或电子编码已存在")]
        public const CallResult EntryCodeFail = CallResult.Max + 15;
        [Description("未找到可用的设备")]
        public const CallResult EquipmentCodeError = CallResult.Max + 16;
        [Description("操作记录不存在")]
        public const CallResult RecordNoExist = CallResult.Max + 17;
        [Description("服务器处理异常")]
        public const CallResult handleException = CallResult.Max + 18;
        [Description("设备类型不匹配 ")]
        public const CallResult EquipmentTypeError = CallResult.Max + 19;
        [Description("导入成功")]
        public const CallResult ImportSuccess = CallResult.Max + 20;
        [Description("导入失败")]
        public const CallResult ImportFail = CallResult.Max + 21;

        public const CallResult DuplicateLogin = CallResult.Max + 22;
        [Description("数据格式转换有误")]
        public const CallResult DataConvertError = CallResult.Max + 23;
        [Description("数据更新错误")]
        public const CallResult DataUPdateError = CallResult.Max + 24;
        /// <summary>
        /// 文件不存在
        /// </summary>
        [Description("升级文件不存在")]
        public const CallResult UpGradeFileNoExists = CallResult.Max + 25;
    }
}
