using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace EnumTest
{
    public enum CallResult
    {
        /// <summary>
        /// 没有数据
        /// </summary>
        [Description("没有数据")]
        NoData = -1,
        /// <summary>
        /// 调用成功
        /// </summary>
        [Description("请求成功")]
        Success = 0,
        /// <summary>
        /// 调用失败
        /// </summary>
        [Description("请求失败")]
        Fail = 1,
        /// <summary>
        /// 名称重复
        /// </summary>
        [Description("名称重复")]
        DupplicateName = 2,
        /// <summary>
        /// 身份证号码重复
        /// </summary>
        [Description("身份证号码重复")]
        DupplicateIdCard = 3,
        /// <summary>
        /// 工号重复
        /// </summary>
        [Description("工号重复")]
        DupplicateJobNumber = 4,
        /// <summary>
        /// 代码重复
        /// </summary>
        [Description("代码重复")]
        DupplicateCode = 5,
        /// <summary>
        /// 电话号码重复
        /// </summary>
        [Description("电话号码重复")]
        DupplicateTelephone = 6,
        /// <summary>
        /// 登录名称重复
        /// </summary>
        [Description("登录名称重复")]
        DuplicateLoginName = 7,
        /// <summary>
        /// 父级错误
        /// </summary>
        [Description("父级错误")]
        ParentLevelError = 8,
        /// <summary>
        /// 线路不存在
        /// </summary>
        [Description("线路不存在")]
        LineNotExists = 9,
        /// <summary>
        /// 站点不存在
        /// </summary>
        [Description("站点不存在")]
        StationNoExists = 10,
        /// <summary>
        /// 工区不存在
        /// </summary>
        [Description("工区不存在")]
        RangeNoExists = 11,
        /// <summary>
        /// 设备类型不存在
        /// </summary>
        [Description("设备类型不存在")]
        EquipTypeNoExist = 12,
        /// <summary>
        /// 单位和线路的映射关系已经存在
        /// </summary>
        [Description("单位和线路的映射关系已经存在")]
        CompanyLineExists = 13,
        /// <summary>
        /// 单位不存在
        /// </summary>
        [Description("单位不存在")]
        CompanyNoExist = 14,
        /// <summary>
        /// 读取excel文件失败
        /// </summary>
        [Description("读取excel文件失败")]
        ReadExcelFail = 15,
        /// <summary>
        /// 工区内存在人员
        /// </summary>
        [Description("工区内存在人员")]
        ExistStaff = 16,
        /// <summary>
        /// 存在子级关系
        /// </summary>
        [Description("存在子级关系")]
        ExistChild = 17,
        /// <summary>
        /// 供应商不存在
        /// </summary>
        [Description("供应商不存在")]
        SupplierNoExist = 18,
        /// <summary>
        /// 设备状态不存在
        /// </summary>
        [Description("设备状态不存在")]
        EquipStatNoExist = 19,
        /// <summary>
        /// 维护周期错误
        /// </summary>
        [Description("维护周期错误")]
        CycleNoExist = 20,
        /// <summary>
        /// 安装位置状态错误
        /// </summary>
        [Description("安装位置状态错误")]
        InstallStatError = 21,
        /// <summary>
        /// 仓库不存在
        /// </summary>
        [Description("仓库不存在")]
        StockNoExist = 22,
        /// <summary>
        /// 安装位置不存在
        /// </summary>
        [Description("安装位置不存在")]
        InstallSiteNoExist = 23,
        /// <summary>
        /// 仓库已经存在
        /// </summary>
        [Description("仓库已经存在")]
        StockHasExist = 24,
        /// <summary>
        /// 检测项模板存在
        /// </summary>
        [Description("检测项模板存在")]
        ItemTemplate = 25,
        /// <summary>
        /// 手机未授权
        /// </summary>
        [Description("手机未授权")]
        MobileDeviceError = 26,
        /// <summary>
        /// 未识别的文件类型
        /// </summary>
        [Description("未识别的文件类型")]
        UnRecognizedFileType = 27,

        /// <summary>
        /// 内部服务器错误
        /// </summary>
        InnerServerError = 28,
        [Description("已重复登录，用户将不能进行操作")]
        DuplicateLogin = 29,

        /// <summary>
        /// 未识别的方法
        /// </summary>
        [Description("未识别的方法")]
        UnRcognizedMethod = 101,

        // ToolsAction
        [Description("解除标签绑定失败")]
        ToolsRemoveBindingFail = 108,
        [Description("解除标签绑定成功")]
        ToolsRemoveBindingSuccess = 109,
        [Description("查询工具列表成功")]
        GetToolsListSuccess = 110,
        [Description("获取工具出库列表成功")]
        GetToolsOutStockListSuccess = 111,
        [Description("工具工装入场成功")]
        ToolsInSuccess = 112,
        [Description("工具工装出场成功")]
        ToolsOutSuccess = 113,
        [Description("工具工装出库成功")]
        ToolsBorrowSuccess = 114,
        [Description("工具工装入库成功")]
        ToolsReturnSuccess = 115,
        [Description("查询入库工具工装列表成功")]
        GetToolsInToolsListSuccess = 116,
        [Description("工具工装绑定成功")]
        ToolsBindingSuccess = 117,
        [Description("工具工装查询成功")]
        ToolsSearchSuccess = 118,
        [Description("工具工装查询无记录")]
        ToolsSearchFail = 119,





        [Description("未找到对应的作业")]
        ToolsNoExistWork = 120,
        [Description("未查询到工具")]
        ToolsNotFoundToolsByRFID = 121,
        [Description("报废工具标签失败")]
        ToolsScrapFailed = 122,
        [Description("未查询到工具")]
        ToolsNotFoundToolsByCode = 123,
        [Description("工具前缀获取成功")]
        ToolsPrecodeSuccess = 124,
        [Description("工具前缀获取失败")]
        ToolsPrecodeFail = 125,
        [Description("工具工装报废标签成功")]
        ToolsScrapSuccess = 126,
        [Description("工具编号已使用")]
        ToolsNumberRepeat = 127,
        [Description("新建包裹失败")]
        ToolAddBagFail = 128,
        [Description("请求参数错误")]
        ToolParameterFail = 129,

        //Equipment
        [Description("设备绑定成功")]
        EquipmentBindSuccess = 131,
        [Description("设备类型查询成功")]
        EquipmentEquipmentTypeSuccess = 132,
        [Description("设备解绑成功")]
        EquipmentUnBindSuccess = 133,

        //Fail
        [Description("错误的请求")]
        BadRequest = 141,

        //MaintenanceEquipmentInfo
        [Description("维护设备信息查询成功")]
        MaintenanceEquipmentInfoSuccess = 151,

        //MonthPlan

        [Description("月计划查询成功")]
        MonthPlanListSuccess = 161,
        [Description("月计划完成成功")]
        MonthPlanCompleteSuccess = 162,

        [Description("用户ID错误")]
        MonthPlanUserIDError = 163,
        [Description("月计划完成失败，请求的数据无效")]
        MonthPlanCompleteError = 164,

        //ProtectionLog

        [Description("查询防护日志记录成功")]
        ProtectionLogSuccess = 171,
        [Description("添加防护日志记录成功")]
        ProtectionADDLogSuccess = 172,
        [Description("更新防护日志记录更新成功")]
        ProtectionLogUpdateSuccess = 173,
        [Description("删除防护日志记录成功")]
        ProtectionLogDeleteSuccess = 174,
        [Description("添加防护日志记录详细信息成功")]
        ProtectionLogAddDetailSuccess = 175,
        [Description("删除防护日志详细信息成功")]
        ProtectionLogDeleteDetailSuccess = 176,
        [Description("更新防护日志详细信息成功")]
        ProtectionLogUpdateDetailSuccess = 176,

        [Description("传入数据格式有误")]
        ProtectionLogWorkIDPlanIDError = 179,

        //RecordAction
        [Description("记录查询成功")]
        RecordListItemSuccess = 181,
        [Description("设备记录查询成功")]
        RecordListDeviceSuccess = 182,
        [Description("设备记录子项查询成功")]
        RecordListItemDeviceSuccess = 183,

        [Description("用户标识错误!")]
        RecordUserIdError = 184,
        [Description("所属单位错误!")]
        RecordCompanyError = 185,
        [Description("计划不存在!")]
        RecordPlanNoExist = 186,
        [Description("报表的模板不存在")]
        RecordTemplateNoExist = 187,
        [Description("站点不存在")]
        RecordStationNoExist = 188,
        [Description("报表详情查询成功")]
        RecordReportDetailSuccess = 189,
        [Description("巡检记录保存成功!")]
        RecordSaveSuccess = 190,
        [Description("巡检记录保存失败!")]
        RecordSaveFail = 191,
        [Description("巡检记录数据错误")]
        RecordDataError = 192,

        //Staff
        [Description("人员记录查询成功")]
        StaffListSuccess = 301,

        //Station
        [Description("错误的RFID")]
        StationBadRFID = 311,
        [Description("站点列表查询成功")]
        StationListSuccess = 312,
        [Description("没有查询到对应到机房信息！")]
        StationNoData = 313,
        [Description("查询站点信息成功")]
        StationInfoSuccess = 314,
        [Description("站点报表信息查询成功")]
        StationReportInfoSuccess = 315,
        [Description("错误的用户名")]
        StationUserNameError = 316,
        [Description("没有查询到机架")]
        StationNoShelf = 317,

        //Work
        [Description("作业操作请求失败")]
        WorkBadRequest = 421,
        [Description("作业创建成功")]
        WorkNewSuccess = 422,
        [Description("作业更新成功")]
        WorkChangeSuccess = 423,
        [Description("作业完成成功")]
        WorkFinishSuccess = 424,
        [Description("作业删除成功")]
        WorkDeleteSuccess = 425,
        //防行
        [Description("实时监控已登记")]
        TagHaxCheckIn = 500,
        [Description("实时监控登记成功")]
        TagCheckInSuccess = 501,
        [Description("实时监控登记失败")]
        TagCheckInFail = 502,
        [Description("删除实时监控失败")]
        TagDeleteMoniterFail = 503,
        [Description("删除实时监控成功")]
        TagDeleteMoniterSuccess = 504,
        [Description("开始实时监控成功")]
        TagBeginMoniterSuccess = 505,
        [Description("开始实时监控失败")]
        TagBeginMoniterFail = 506,
        [Description("结束实时监控成功")]
        TagFinishMoniterSuccess = 507,
        [Description("结束实时监控失败")]
        TagFinishMoniterFail = 508,
        [Description("没有实时监控数据")]
        TagMoniterListNoData = 509,
        [Description("获取实时监控数据成功")]
        TagMoniterListSuccess = 510,
        [Description("获取实时监控数据失败")]
        TagMoniterListFail = 511,

        [Description("人员入场成功")]
        StaffAdmissionSuccess = 601,
        [Description("人员入场失败")]
        StaffAdmissionFail = 602,
        [Description("错误的工牌!")]
        StaffCardError,
        [Description("账号没有注册!")]
        AccountError,
        [Description("登陆成功!")]
        LoginSuccess = 701,
        [Description("登陆失败!")]
        LoginFail = 702,

        [Description("标签Mac地址为空！")]
        BthTagIDError = 801,
        [Description("标签编号为空！")]
        BthTagJMError = 802,
        [Description("标签类型为空！")]
        BthTagTypeError = 803,
        [Description("标签记录未找到！")]
        BthIDError = 803,

        Max = 0x10000000,
    }

    public static class EnumExtensions
    {
        /// <summary>
        /// 获取描述
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetDescription(this object value)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()) || value.ToString() == "0") return string.Empty;

            if (EnumDescription.ContainsKey((CallResult)value))
            {
                return EnumDescription.Get((CallResult)value);
            }

            var type = value.GetType();
            var field = type.GetField(Enum.GetName(type, value));
            if (field != null)
            {
                var des = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
                if (des != null)
                {
                    return des.Description;
                }
            }
            return type.Name;
        }
    }

    public static class EnumDescription
    {
        private static Dictionary<CallResult, string> dictionary = new Dictionary<CallResult, string>();

        public static void Add(CallResult result, string description)
        {
            if (!dictionary.ContainsKey(result))
            {
                dictionary.Add(result, description);
            }
        }

        public static string Get (CallResult result)
        {
            if (dictionary.ContainsKey(result))
            {
                return dictionary[result];
            }
            return null;
        }

        public static bool ContainsKey(CallResult result)
        {
            return dictionary.ContainsKey(result);
        }
    }
}

