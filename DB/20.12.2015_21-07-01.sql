-- Author: Johnny Svarog
-- Справочник статусов портала


/*==============================================================*/
/* Table: JSP_DicStatuses                                       */
/*==============================================================*/
create table JSP_DicStatuses (
   id                   BIGSERIAL            not null,
   Name_EN              VARCHAR(25)          not null,
   Name_RU              VARCHAR(25)          not null,
   DateStart            DATE                 not null,
   DateEnd              DATE                 null,
   constraint PK_JSP_DICSTATUSES primary key (id)
);

comment on table JSP_DicStatuses is
'Справочник статусов записей портала';

comment on column JSP_DicStatuses.id is
'Идентификатор';

comment on column JSP_DicStatuses.Name_EN is
'Наименование на английском';

comment on column JSP_DicStatuses.Name_RU is
'Наименование на русском';

comment on column JSP_DicStatuses.DateStart is
'Дата начала  действия';

comment on column JSP_DicStatuses.DateEnd is
'Дата завершения действия';