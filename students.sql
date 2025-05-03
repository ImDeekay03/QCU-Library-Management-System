--------------------------------------------------------
--  File created - Wednesday-April-30-2025   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table STUDENTS
--------------------------------------------------------

  CREATE TABLE "SYSTEM"."STUDENTS" 
   (	"STUDENT_ID" VARCHAR2(50 BYTE), 
	"LAST_NAME" VARCHAR2(50 BYTE), 
	"FIRST_NAME" VARCHAR2(50 BYTE), 
	"MIDDLE_NAME" VARCHAR2(50 BYTE), 
	"EMAIL" VARCHAR2(100 BYTE), 
	"PROGRAM" VARCHAR2(100 BYTE), 
	"IMAGE" BLOB
   ) PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" 
 LOB ("IMAGE") STORE AS BASICFILE (
  TABLESPACE "SYSTEM" ENABLE STORAGE IN ROW CHUNK 8192 RETENTION 
  NOCACHE LOGGING 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)) ;
REM INSERTING into SYSTEM.STUDENTS
SET DEFINE OFF;
Insert into SYSTEM.STUDENTS (STUDENT_ID,LAST_NAME,FIRST_NAME,MIDDLE_NAME,EMAIL,PROGRAM) values ('23-0009','Taylor','Noah','Alexander','test@student.edu','Bachelor of Science in Information Technology');
Insert into SYSTEM.STUDENTS (STUDENT_ID,LAST_NAME,FIRST_NAME,MIDDLE_NAME,EMAIL,PROGRAM) values ('23-1234','Random','Person',null,'test2@gmail.com','Bachelor of Science in Information Technology');
--------------------------------------------------------
--  DDL for Index SYS_C007028
--------------------------------------------------------

  CREATE UNIQUE INDEX "SYSTEM"."SYS_C007028" ON "SYSTEM"."STUDENTS" ("EMAIL") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  Constraints for Table STUDENTS
--------------------------------------------------------

  ALTER TABLE "SYSTEM"."STUDENTS" ADD UNIQUE ("EMAIL")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
  ALTER TABLE "SYSTEM"."STUDENTS" ADD CHECK (program IN ('Bachelor of Science in Information Technology', 'Bachelor of Science in Information System', 'Bachelor of Science in Computer Science',
   'Bachelor of Science in Accountancy', 'Bachelor of Science in Management Accounting', 'Bachelor of Science in Entrepreneurship', 'Bachelor of Science in Electronics Engineering', 'Bachelor of Science in Industrial Engineering', 'Bachelor in Early Childhood Education'  )) ENABLE;
  ALTER TABLE "SYSTEM"."STUDENTS" MODIFY ("EMAIL" NOT NULL ENABLE);
  ALTER TABLE "SYSTEM"."STUDENTS" MODIFY ("FIRST_NAME" NOT NULL ENABLE);
  ALTER TABLE "SYSTEM"."STUDENTS" MODIFY ("LAST_NAME" NOT NULL ENABLE);
  ALTER TABLE "SYSTEM"."STUDENTS" MODIFY ("STUDENT_ID" NOT NULL ENABLE);
