using Gir.Vns.Dtos.BcVersionSliceWells.GetBcVersionSliceWells.Enums;

namespace Gir.Vns.Dtos.BcVersionSliceWells.GetBcVersionSliceWells;

/// <summary>
/// Атрибуты скважины среза версии БК.
/// </summary>
public class BcVersionSliceWellAttributesDto
{
    // 🎯 Свойства
    /// <summary>
    /// Геологический номер (1, 0, 99).
    /// </summary>
    public short? GeologyNumber { get; set; }

    /// <summary>
    /// Геологическая позиция скважины.
    /// </summary>
    public WellGeologyPosition? GeologyPosition { get; set; }

    /// <summary>
    /// Порядковый номер.
    /// </summary>
    public int SequenceNumber { get; set; }

    /// <summary>
    /// Ун.н.
    /// </summary>
    public string? UniqueNumber1 { get; set; }

    /// <summary>
    /// Ун.н.2.
    /// </summary>
    public string? UniqueNumber2 { get; set; }

    /// <summary>
    /// ID типа скважины (из MDM сервиса).
    /// </summary>
    public Guid? WellTypeId { get; set; }

    /// <summary>
    /// ID назначения скважины (из MDM сервиса).
    /// </summary>
    public Guid? WellPurposeId { get; set; }

    /// <summary>
    /// ID состояния скважины (из MDM сервиса).
    /// </summary>
    public Guid? WellConditionId { get; set; }

    /// <summary>
    /// ID характера скважины (из MDM сервиса).
    /// </summary>
    public Guid? WellNatureId { get; set; }

    /// <summary>
    /// ID способа эксплуатации скважины (из MDM сервиса).
    /// </summary>
    public Guid? WellExploitationId { get; set; }

    /// <summary>
    /// ID типа модуля (из MDM сервиса).
    /// </summary>
    public Guid? ModuleTypeId { get; set; }

    /// <summary>
    /// Длина ГС 1 (осн. ствол).
    /// </summary>
    public short? GsLength { get; set; }

    /// <summary>
    /// Конструкция ГС.
    /// </summary>
    public string? GsDesign { get; set; }

    /// <summary>
    /// Тип ГРП.
    /// </summary>
    /// <remarks>
    /// - ГРП отсутствует.
    /// </remarks>
    public WellGrpType? GrpType { get; set; }

    /// <summary>
    /// Кол-во стадий.
    /// </summary>
    public short? StageCount { get; set; }

    /// <summary>
    /// Масса пропана тн/стад.
    /// </summary>
    public decimal? PropaneMassPerStage { get; set; }

    /// <summary>
    /// Масса пропана тн.
    /// </summary>
    public decimal? PropaneMassTotal { get; set; }

    /// <summary>
    /// Наличие пилота.
    /// </summary>
    public bool HasPilot { get; set; }

    /// <summary>
    /// Оптим. днз.
    /// </summary>
    public bool IsOptimizedDesign { get; set; }

    /// <summary>
    /// ГНКТ.
    /// </summary>
    public string? Gnkt { get; set; }

    /// <summary>
    /// Дата ввода/сдачи.
    /// </summary>
    public DateOnly? DateLaunch { get; set; }

    /// <summary>
    /// Месяц ввода.
    /// </summary>
    public short? DeliveryMonth { get; set; }

    /// <summary>
    /// Год ввода.
    /// </summary>
    public short? DeliveryYear { get; set; }

    /// <summary>
    /// Дата забурки из 2БП_Расчет.
    /// </summary>
    public DateOnly? DateDrilling2Bp { get; set; }

    /// <summary>
    /// Год забурки КП.
    /// </summary>
    public short? ClusterDrillingYear { get; set; }

    /// <summary>
    /// Номер этапа.
    /// </summary>
    public short? StageNumber { get; set; }

    /// <summary>
    /// Кол-во ПУ.
    /// </summary>
    public short? PuCount { get; set; }


    // 🛠 Конструкторы
}