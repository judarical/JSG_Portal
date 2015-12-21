-- Author: Johnny Svarog
-- ���������� �������� �������


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
'���������� �������� ������� �������';

comment on column JSP_DicStatuses.id is
'�������������';

comment on column JSP_DicStatuses.Name_EN is
'������������ �� ����������';

comment on column JSP_DicStatuses.Name_RU is
'������������ �� �������';

comment on column JSP_DicStatuses.DateStart is
'���� ������  ��������';

comment on column JSP_DicStatuses.DateEnd is
'���� ���������� ��������';