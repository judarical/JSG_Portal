/*
* Created by: Yevgeniy A. Matveichev
* Created: 20/12/2015
* Copyright © Johnny Svarog 2015
*/


namespace JSC.Host.DomainModels.EntityModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Справочник Статусов.
    /// </summary>
    public partial class JSP_DicStatuses
    {
        [Display(Name = "Id", Prompt = "Идентификатор записи")]
        public long id { get; set; }

        [Required]
        [Display(Name = "Дата окончания записи", Prompt = "Дата окончания записи")]
        public string Name_EN { get; set; }

        [Required]
        [Display(Name = "Id", Prompt = "Идентификатор записи")]
        public string Name_RU { get; set; }

        [Required]
        [Display(Name = "Дата начала", Prompt = "Дата начала действия записи")]
        public DateTime DateStart { get; set; }

        [Display(Name = "Дата окончания", Prompt = "Дата, по наступлению которой запись справочника становится неактуальной")]
        public DateTime ? DateEnd { get; set; }
    }
}
