using System.Reflection;

namespace Gir.Vns.Dtos.Benefits;

/// <summary>
/// DTO Проектируемая скважина.
/// </summary>
/// <inheritdoc/>
public class ProjectWell
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    public long? Id { get; set; }

    /// <summary>
    /// Признак удаления записи.
    /// </summary>
    public bool IsDeleted { get; set; }

    ///// <summary>
    ///// Тип скважины
    ///// </summary>
    //public WellType? WellType { get; set; }

    ///// <summary>
    ///// Назначение скважины
    ///// </summary>
    //public WellPurpose? WellPurpose { get; set; }

    ///// <summary>
    ///// Состояние скважины
    ///// </summary>
    //public WellCondition? WellCondition { get; set; }

    ///// <summary>
    ///// Способ эксплуатации
    ///// </summary>
    //public WellExploitation? WellExploitation { get; set; }

    ///// <summary>
    ///// Характер скважины
    ///// </summary>
    //public WellNature? WellNature { get; set; }

    /// <summary>
    /// Микросейсмична
    /// </summary>
    public bool Microseismic { get; set; }

    /// <summary>
    /// Фактическая дата начала работы скважины
    /// </summary>
    public DateTime? DateStartWellFact { get; set; }

    /// <summary>
    /// ИД Скважины
    /// </summary>
    public long? WellsId { get; set; }

    /// <summary>
    /// Length
    /// </summary>
    public decimal? Length { get; set; }

    /// <summary>
    /// Конструкция
    /// </summary>
    public short? Construction { get; set; }

    /// <summary>
    /// Название конструкции
    /// </summary>
    public string? ConstructionName { get; set; }// => ProjectWellConstructionTypes.AsString(Construction);

    /// <summary>
    /// IsMgrp
    /// </summary>
    public short? IsMgrp { get; set; }

    /// <summary>
    /// Stages
    /// </summary>
    public decimal? Stages { get; set; }

    /// <summary>
    /// ProppantMassTn
    /// </summary>
    public decimal? ProppantMassTn { get; set; }

    /// <summary>
    /// ProppantMassTnSt
    /// </summary>
    public decimal? ProppantMassTnSt { get; set; }

    /// <summary>
    /// DebJidM3D
    /// </summary>
    public decimal? DebJidM3D { get; set; }

    /// <summary>
    /// DebNfTd
    /// </summary>
    public decimal? DebNfTd { get; set; }

    /// <summary>
    /// WaterCut
    /// </summary>
    public decimal? WaterCut { get; set; }

    /// <summary>
    /// ExitModeD
    /// </summary>
    public decimal? ExitModeD { get; set; }

    /// <summary>
    /// NameNtc
    /// </summary>
    public string? NameNtc { get; set; }

    /// <summary>
    /// Perforation
    /// </summary>
    public string? Perforation { get; set; }

    /// <summary>
    /// ComplexGis
    /// </summary>
    public string? ComplexGis { get; set; }

    /// <summary>
    /// DateStartWell
    /// </summary>
    public DateTime? DateStartWell { get; set; }

    /// <summary>
    /// Working
    /// </summary>
    public decimal? Working { get; set; }

    /// <summary>
    /// DateDrilling
    /// </summary>
    public DateTime? DateDrilling { get; set; }

    /// <summary>
    /// Дата забурки, подтвержденная ПСД
    /// </summary>
    public DateTime? DateDrillingPsd { get; set; }

    /// <summary>
    /// Дата запуска скважины
    /// </summary>
    public DateTime? DateLaunchWell { get; set; }

    /// <summary>
    /// IsBps
    /// </summary>
    public bool? IsBps { get; set; }

    /// <summary>
    /// IsGnkt
    /// </summary>
    public bool? IsGnkt { get; set; }

    /// <summary>
    /// IsTpa
    /// </summary>
    public bool? IsTpa { get; set; }

    /// <summary>
    /// IsDns
    /// </summary>
    public string? IsDns { get; set; }

    /// <summary>
    /// IsDesignOptim
    /// </summary>
    public bool? IsDesignOptim { get; set; }

    /// <summary>
    /// IsGeo
    /// </summary>
    public string? IsGeo { get; set; }

    /// <summary>
    /// Модуль
    /// </summary>
    //public Module? Module { get; set; }

    /// <summary>
    /// IsPilot
    /// </summary>
    public bool IsPilot { get; set; }

    ///// <summary>
    ///// Тип модуля
    ///// </summary>
    //public ModuleType? ModuleType { get; set; }

    /// <summary>
    /// IsEvaluation
    /// </summary>
    public bool? IsEvaluation { get; set; }

    /// <summary>
    /// LengthT2T3
    /// </summary>
    public decimal? LengthT2T3 { get; set; }

    /// <summary>
    /// длина ГС (проходка по факту)
    /// </summary>
    public decimal? LengthFact { get; set; }

    /// <summary>
    /// Проект
    /// </summary>
    public string? Project { get; set; }

    /// <summary>
    /// Пилот, м
    /// </summary>
    public decimal? Pilot { get; set; }

    /// <summary>
    /// Длина ствола (проходка по плану (КБ))
    /// </summary>
    public decimal? LengthPlan { get; set; }

    /// <summary>
    /// ИД Версия прогноза сценария
    /// </summary>
    public long? CaseVersionForecastId { get; set; }

    /// <summary>
    /// Признак основной версии прогноза
    /// </summary>
    public bool IsBasic { get; set; }

    ///// <summary>
    ///// Коллекция связанных Пластов
    ///// </summary>
    //public IEnumerable<LayerWell>? LayerWells { get; set; }

    ///// <summary>
    ///// Коллекция доп признаков
    ///// </summary>
    //public IEnumerable<WellAdditionalSign>? WellAdditionalSigns { get; set; }

    ///// <summary>
    ///// Коллекция связанных доп. Исследований
    ///// </summary>
    //public IEnumerable<AdditionalExplorationWell>? AdditionalExplorationWells { get; set; }

    ///// <summary>
    ///// Коллекция связанных типов Исследований
    ///// </summary>
    //public IEnumerable<ExplorationWell>? ExplorationWells { get; set; }

    ///// <summary>
    ///// Координаты
    ///// </summary>
    //public IEnumerable<Coordinates.Coordinates>? Coordinates { get; set; }

    /// <summary>
    /// Для Хантоса! Темп падения, %
    /// </summary>
    public decimal? DeclineRate { get; set; }

    /// <summary>
    /// Для Хантоса! Смещение ННС, м
    /// </summary>
    public decimal? Displacement { get; set; }

    /// <summary>
    /// Для Хантоса! Примечания
    /// </summary>
    public string? Comment { get; set; }

    /// <summary>
    /// Для Хантоса! Количество пластов для ННС
    /// </summary>
    public int? CntLayerNns { get; set; }

    /// <summary>
    /// Для Хантоса! Примечания для конструкции
    /// </summary>
    public string? ConstructionComment { get; set; }

    /// <summary>
    /// Для Хантоса! Отработка ППД, мес
    /// </summary>
    public int? WorkingPpd { get; set; }

    /// <summary>
    /// Список пластов
    /// </summary>
    public List<long>? LayerIdList { get; set; }

    /// <summary>
    /// Эффективность проводки ГС
    /// </summary>
    public int TargetingEfficiency { get; set; }

    /// <summary>
    /// Плановый срок регистрации
    /// </summary>
    public DateTime? DateStateRegPlan { get; set; }

    /// <summary>
    /// Фактический срок регистрации
    /// </summary>
    public DateTime? DateStateRegFact { get; set; }

    /// <summary>
    /// Порядковый номер скважины на кусте.
    /// </summary>
    /// <remarks>
    /// 1. Используется в геоле и графике бурения.<br/>
    /// 2. Привязан к кусту.<br/>
    /// 3. Не равен project_wells.sequence_number.<br/>
    /// </remarks>
    public int? Index { get; set; }

    /// <summary>
    /// Передвижка.
    /// </summary>
    public int? Transport { get; set; }

    /// <summary>
    /// Ун.н.
    /// </summary>
    public string? UniqueNumber1 { get; set; }

    /// <summary>
    /// Ун.н.2
    /// </summary>
    public string? UniqueNumber2 { get; set; }

    /// <summary>
    /// № п/п
    /// </summary>
    /// <remarks>
    /// 1.Не равен project_wells.index. <br/>
    /// 2.Не привязан к кусту. <br/>
    /// </remarks>
    public long? SequenceNumber { get; set; }

    /// <summary>
    /// Нач/пос скв
    /// </summary>
    public long? GeologyNumber { get; set; }

    /// <summary>
    /// Мобилизация(Дата).
    /// </summary>
    public DateTime? MobilizationDate { get; set; }

    /// <summary>
    /// Дата рабочей документации.
    /// </summary>
    public DateTime? DateWorkingDocument { get; set; }
}