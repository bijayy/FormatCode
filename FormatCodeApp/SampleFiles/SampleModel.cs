using EZCAP_Base;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace EZCAPAuthAPI
{
    public class clsAuthRectype010
    {
        private string STRANSTYPE;

        public string TRANSTYPE
        {
            get
            {
                return STRANSTYPE;
            }

            set
            {
                try
                {
                    STRANSTYPE = value;
                }
                catch (Exception ex)
                {
                }
            }
        }
        private string sMEMBMPI = string.Empty;

        public string MEMBMPI
        {
            get
            {
                return sMEMBMPI;
            }

            set
            {
                try
                {
                    sMEMBMPI = value;
                }
                catch (Exception ex)
                {
                }
            }
        }

        private string SRECTYPE;

        public string RECTYPE
        {
            get
            {
                return SRECTYPE;
            }

            set
            {
                try
                {
                    SRECTYPE = value;
                }

                catch (Exception ex)
                {
                }
            }
        }

        private string _sRequstingProvd;

        public string REQSTINGPROVID
        {
            get
            {
                return _sRequstingProvd;
            }

            set
            {
                try
                {
                    _sRequstingProvd = value;
                }
                catch (Exception ex)
                {
                }
            }
        }

        private string _sReqstdPROVID;

        public string REQPROVIDERID
        {
            get
            {
                return _sReqstdPROVID;
            }

            set
            {
                try
                {
                    _sReqstdPROVID = value;
                }
                catch (Exception ex)
                {
                }

            }
        }
        private string _sMEMBERID;
        public string MEMBERID
        {
            get
            {
                return _sMEMBERID;
            }

            set
            {
                try
                {
                    _sMEMBERID = value;
                }

                catch (Exception ex)
                {
                }
            }
        }
        private string _sLOS;
        public string LOS
        {
            get
            {
                return _sLOS;
            }

            set
            {
                try
                {
                    _sLOS = value;
                }

                catch (Exception ex)
                {
                }
            }
        }
        private string _sAuthStatus;
        public string AUTHSTATUS
        {
            get
            {
                return _sAuthStatus;
            }

            set
            {
                try
                {
                    _sAuthStatus = value;
                }

                catch (Exception ex)
                {
                }
            }
        }
        private int _nAuthStatus;
        public int nAUTHSTATUS
        {
            get
            {
                return _nAuthStatus;
            }

            set
            {
                try
                {
                    _nAuthStatus = value;
                }

                catch (Exception ex)
                {
                }
            }
        }
        private string _sHPAUTHNO;

        public string HPAUTHNO
        {
            get
            {
                return _sHPAUTHNO;
            }

            set
            {
                try
                {
                    _sHPAUTHNO = value;
                }

                catch (Exception ex)
                {
                }
            }
        }
        private string _sAUTHNO = string.Empty;

        public string AUTHNO
        {
            get
            {
                return _sAUTHNO;
            }

            set
            {
                try
                {
                    _sAUTHNO = value;
                }

                catch (Exception ex)
                {
                }
            }
        }
        private string _sREQDATE;

        public string REQDATE
        {
            get
            {
                return _sREQDATE;
            }

            set
            {
                try
                {
                    _sREQDATE = value;
                }
                catch (Exception ex)
                {

                }
            }
        }
        private string NUMDIAG;

        public string NDIAG
        {
            get
            {
                return NUMDIAG;
            }

            set
            {
                try
                {
                    NUMDIAG = value;
                }
                catch (Exception ex)
                {

                }

            }
        }

        private string NUMDETAILS;

        public string NDETAILS
        {
            get
            {
                return NUMDETAILS;
            }
            set
            {
                try
                {
                    NUMDETAILS = value;
                }
                catch (Exception ex)
                {

                }
            }
        }

        private string NUMMEMOS;

        public string NMEMO
        {
            get
            {
                return NUMMEMOS;
            }

            set
            {
                try
                {
                    NUMMEMOS = value;
                }
                catch (Exception ex)
                {

                }
            }
        }

        private string NUMNOTES;

        public string NNOTES
        {
            get
            {
                return NUMNOTES;
            }

            set
            {
                try
                {
                    NUMNOTES = value;
                }
                catch (Exception ex)
                {

                }
            }
        }

        private string SREQAPPID;

        public string REQAPPID
        {
            get
            {
                return SREQAPPID;
            }

            set
            {
                try
                {
                    SREQAPPID = value;
                }
                catch (Exception ex)
                {

                }
            }
        }

        private string _sPLACESVC;

        public string PLACESVC
        {
            get
            {
                return _sPLACESVC;
            }

            set
            {
                try
                {
                    _sPLACESVC = value;
                }
                catch (Exception ex)
                {

                }
            }
        }
        private int _nPLACESVC;

        public int nPLACESVC
        {
            get
            {
                return _nPLACESVC;
            }

            set
            {
                try
                {
                    _nPLACESVC = value;
                }
                catch (Exception ex)
                {

                }
            }
        }
        private string NBRUNITS;

        public string NUMOFUNITS
        {
            get
            {
                return NBRUNITS;
            }

            set
            {
                try
                {
                    NBRUNITS = value;
                }
                catch (Exception ex)
                {

                }
            }
        }

        private string CASENO;

        public string CASENUMBER
        {
            get
            {
                return CASENO;
            }

            set
            {
                try
                {

                    CASENO = value;
                }
                catch (Exception ex)
                {

                }
            }
        }

        private string SHPCODE;

        public string HPCODE
        {
            get
            {
                return SHPCODE;
            }

            set
            {
                try
                {
                    SHPCODE = value;
                }
                catch (Exception ex)
                {

                }
            }
        }
        private string sOverWriteflag;

        public string OVERWRITEFLAG
        {
            get
            {
                return sOverWriteflag;
            }

            set
            {
                try
                {
                    sOverWriteflag = value;
                }
                catch (Exception ex)
                {

                }
            }
        }
        private string sSVCTYPE;

        public string SVCTYPE
        {
            get
            {
                return sSVCTYPE;
            }

            set
            {
                try
                {
                    sSVCTYPE = value;
                }
                catch (Exception ex)
                {

                }
            }
        }
        private string nSVCTYPEID = 0.ToString();

        public string SVCTYPEID
        {
            get
            {
                return nSVCTYPEID;
            }

            set
            {
                try
                {
                    nSVCTYPEID = value;
                }
                catch (Exception ex)
                {

                }
            }
        }
        private string sSVCFACID;

        public string SVCFACID
        {
            get
            {
                return sSVCFACID;
            }

            set
            {
                try
                {
                    sSVCFACID = value;
                }
                catch (Exception ex)
                {

                }
            }
        }
        private string sAUTHACTDATE = string.Empty;

        public string AUTHACTDATE
        {
            get
            {
                return sAUTHACTDATE;
            }

            set
            {
                try
                {
                    sAUTHACTDATE = value;
                }
                catch (Exception ex)
                {

                }
            }
        }
        private string sAUTHEXPDATE = string.Empty;

        public string AUTHEXPDATE
        {
            get
            {
                return sAUTHEXPDATE;
            }

            set
            {
                try
                {
                    sAUTHEXPDATE = value;
                }
                catch (Exception ex)
                {

                }
            }
        }
        private string sACCIDate = string.Empty;

        public string ACCIDATE
        {
            get
            {
                return sACCIDate;
            }

            set
            {
                try
                {
                    sACCIDate = value;
                }
                catch (Exception ex)
                {

                }
            }
        }
        private string sESTDDOB = string.Empty;

        public string ESTDDOB
        {
            get
            {
                return sESTDDOB;
            }

            set
            {
                try
                {
                    sESTDDOB = value;
                }
                catch (Exception ex)
                {

                }
            }
        }
        private string sLMPDATE = string.Empty;

        public string LMPDATE
        {
            get
            {
                return sLMPDATE;
            }

            set
            {
                try
                {
                    sLMPDATE = value;
                }
                catch (Exception ex)
                {

                }
            }
        }
        private string sILLNESS = string.Empty;

        public string ILLNESS
        {
            get
            {
                return sILLNESS;
            }

            set
            {
                try
                {
                    sILLNESS = value;
                }
                catch (Exception ex)
                {

                }
            }
        }
        private string sCERTTYPE;

        public string CERTTYPE
        {
            get
            {
                return sCERTTYPE;
            }

            set
            {
                try
                {
                    sCERTTYPE = value;
                }
                catch (Exception ex)
                {

                }
            }
        }
        private int _nCERTTYPE = 0;

        public int nCERTTYPE
        {
            get
            {
                return _nCERTTYPE;
            }

            set
            {
                try
                {
                    _nCERTTYPE = value;
                }
                catch (Exception ex)
                {

                }
            }
        }
        private string sUDF1;

        public string UDF1
        {
            get
            {
                return sUDF1;
            }

            set
            {
                try
                {
                    sUDF1 = value;
                }
                catch (Exception ex)
                {

                }
            }
        }
        private string sUDF2;

        public string UDF2
        {
            get
            {
                return sUDF2;
            }

            set
            {
                try
                {
                    sUDF2 = value;
                }
                catch (Exception ex)
                {

                }
            }
        }

        private string _SVCFACPROV_KEYID;
        public string out_SVCPROV_KEYID
        {
            get
            {
                return _SVCFACPROV_KEYID;
            }
            set
            {
                _SVCFACPROV_KEYID = value;
            }
        }
        private string _PROV_KEYID;
        public string out_PROV_KEYID
        {
            get
            {
                return _PROV_KEYID;
            }
            set
            {
                _PROV_KEYID = value;
            }
        }
        private string _FACPROV_KEYID;
        public string out_FACPROV_KEYID
        {
            get
            {
                return _FACPROV_KEYID;
            }
            set
            {
                _FACPROV_KEYID = value;
            }
        }
        private string _REQSTDPROV_KEYID; // out_FACPROV_KEYID
        public string out_REQSTDPROV_KEYID
        {
            get
            {
                return _REQSTDPROV_KEYID;
            }
            set
            {
                _REQSTDPROV_KEYID = value;
            }
        }
        private string _REQSTINGPROV_KEYID; // out_FACPROV_KEYID
        public string out_REQSTINGPROV_KEYID
        {
            get
            {
                return _REQSTINGPROV_KEYID;
            }
            set
            {
                _REQSTINGPROV_KEYID = value;
            }
        }
        private string _MEMB_NAME;
        public string OUT_MEMB_NAME
        {
            get
            {
                return _MEMB_NAME;
            }
            set
            {
                _MEMB_NAME = value;
            }
        }
        private string _MEMB_KEYID;
        public string out_MEMB_KEYID
        {
            get
            {
                return _MEMB_KEYID;
            }
            set
            {
                _MEMB_KEYID = value;
            }
        }
        private string _ACCOUNT;
        public string out_ACCOUNT
        {
            get
            {
                return _ACCOUNT;
            }
            set
            {
                _ACCOUNT = value;
            }
        }
        private string _SUBACCOUNT;
        public string out_SUBACCOUNT
        {
            get
            {
                return _SUBACCOUNT;
            }
            set
            {
                _SUBACCOUNT = value;
            }
        }
        private int _SPEC_CODE;
        public int out_SPEC_CODE
        {
            get
            {
                return _SPEC_CODE;
            }
            set
            {
                _SPEC_CODE = value;
            }
        }
        private string _SPECCODE;
        public string out_SPECCODE
        {
            get
            {
                return _SPECCODE;
            }
            set
            {
                _SPECCODE = value;
            }
        }
        private string _VENDOR;
        public string out_VENDOR
        {
            get
            {
                return _VENDOR;
            }
            set
            {
                _VENDOR = value;
            }
        }
        private string CREATEBY;
        public string NCREATEBY
        {
            get
            {
                return CREATEBY;
            }

            set
            {
                CREATEBY = value;
            }
        }
        private DateTime CREATEDATE;
        public DateTime DTCREATEDATE
        {
            get
            {
                return CREATEDATE;
            }

            set
            {
                CREATEDATE = value;
            }
        }
        private string LASTCHANGEBY;
        public string NLASTCHANGEBY
        {
            get
            {
                return LASTCHANGEBY;
            }

            set
            {
                LASTCHANGEBY = value;
            }
        }
        private DateTime LASTCHANGEDATE;
        public DateTime DTLASTCHANGEDATE
        {
            get
            {
                return LASTCHANGEDATE;
            }

            set
            {
                LASTCHANGEDATE = value;
            }
        }
        private List<clsAuthRecType011> STRDIAG = new List<clsAuthRecType011>();
        public List<clsAuthRecType011> DIAGS
        {
            get
            {
                return STRDIAG;
            }
            set
            {
                STRDIAG = value;
            }
        }
        private List<clsAuthRecType020> STRDETAILS = new List<clsAuthRecType020>();
        public List<clsAuthRecType020> DETAILS
        {
            get
            {
                return STRDETAILS;
            }
            set
            {
                STRDETAILS = value;
            }
        }
        private List<clsAuthRecType030> STRMEMOS = new List<clsAuthRecType030>();
        public List<clsAuthRecType030> MEMOS
        {
            get
            {
                return STRMEMOS;
            }
            set
            {
                STRMEMOS = value;
            }
        }
        private List<clsAuthRecType040> STRNOTES = new List<clsAuthRecType040>();
        public List<clsAuthRecType040> NOTES
        {
            get
            {
                return STRNOTES;
            }
            set
            {
                STRNOTES = value;
            }
        }
        private string sPRIORITYSTATUS = string.Empty;
        public string PRIORITYSTATUS
        {
            get
            {
                return sPRIORITYSTATUS;
            }
            set
            {
                sPRIORITYSTATUS = value;
            }
        }

        public object ValidateDECIMAL(string sData, string nScale)
        {

            string nLen;
            string nPoint;

            sData = Conversions.ToString(CheckDecimals(sData));
            nLen = Conversions.Len(sData).ToString();
            if (Conversions.ToBoolean(nLen))
            {
                nPoint = (Conversions.ToDouble(nLen) - Conversions.ToDouble(nScale) + 1d).ToString();
                if (Conversions.Len(sData) > 0)
                {
                    if (Conversions.ToDouble(nScale) == 0d | Conversions.Mid(sData, Conversions.ToInteger(nPoint), 0) == ".")
                    {
                        return true;
                    }
                    return false;
                }
            }
            return true;

        }
        //C# Conversion: To be deleted
        public bool validatedec()
        {

            decimal decTest = 0;

            var niDec = new System.Globalization.NumberFormatInfo();

            niDec.NumberDecimalDigits = 2;

            Debug.WriteLine(decTest.ToString(niDec));
            return default;
        }
        public object CheckDecimals(string strDec)
        {
            string nPos;
            if (Conversions.Len(strDec) > 0 & Conversions.IsNumeric(strDec))
            {
                nPos = Conversions.InStr(strDec, ".").ToString();
                if (Conversions.ToDouble(nPos) < 0d)
                {
                    return strDec + ".00";
                }
                else if (Conversions.Mid(strDec, Conversions.Len(strDec) - 2, 1) == ".")
                {
                    return strDec + "0";
                }
                else if (Conversions.Mid(strDec, Conversions.Len(strDec) - 1, 1) == ".")
                {
                    return strDec + "00";
                }
                return strDec;
            }
            return strDec;
        }
        private string _Errcodes = string.Empty;
        public string Errorcodes
        {
            get
            {
                return _Errcodes;
            }
            set
            {
                _Errcodes = value;
            }
        }
        private string _Errcode = string.Empty;
        public string Errorcode
        {
            get
            {
                return _Errcode;
            }
            set
            {
                _Errcode = value;
            }
        }
        private string _Errorcode = string.Empty;
        public string Errcode
        {
            get
            {
                return _Errorcode;
            }
            set
            {
                _Errorcode = value;
            }
        }
        private string _Errorcode1 = string.Empty;
        public string Errcode1
        {
            get
            {
                return _Errorcode1;
            }
            set
            {
                _Errorcode1 = value;
            }
        }
        private string _GENDER;
        public string out_GENDER
        {
            get
            {
                return _GENDER;
            }
            set
            {
                _GENDER = value;
            }
        }
        private DateTime _BIRTH;
        public DateTime out_BIRTH
        {
            get
            {
                return _BIRTH;
            }
            set
            {
                _BIRTH = value;
            }
        }
        private int _MARITAL;
        public int out_MARITAL
        {
            get
            {
                return _MARITAL;
            }
            set
            {
                _MARITAL = value;
            }
        }
        private string _HP_HPCODE;
        public string out_HP_HPCODE
        {
            get
            {
                return _HP_HPCODE;
            }
            set
            {
                _HP_HPCODE = value;
            }
        }
        private string _HP_OPT;
        public string out_HP_OPT
        {
            get
            {
                return _HP_OPT;
            }
            set
            {
                _HP_OPT = value;
            }
        }
        private string _SUBSSN;
        public string out_SUBSSN
        {
            get
            {
                return _SUBSSN;
            }
            set
            {
                _SUBSSN = value;
            }
        }
        private string _PAYEE;
        public string out_PAYEE
        {
            get
            {
                return _PAYEE;
            }
            set
            {
                _PAYEE = value;
            }
        }
        private int _out_Certification;
        public int out_Certification
        {
            get
            {
                return _out_Certification;
            }
            set
            {
                _out_Certification = value;
            }
        }
        private int _out_SVCTYPE;
        public int out_SVCTYPE
        {
            get
            {
                return _out_SVCTYPE;
            }
            set
            {
                _out_SVCTYPE = value;
            }
        }
        private int _out_Patstatus;
        public int out_PATSTATUS
        {
            get
            {
                return _out_Patstatus;
            }
            set
            {
                _out_Patstatus = value;
            }
        }
        private int _out_PLACE;
        public int out_PLACE
        {
            get
            {
                return _out_PLACE;
            }
            set
            {
                _out_PLACE = value;
            }
        }
        private string _OUT_REQPROV_ID;
        public string OUT_REQPROV_ID
        {
            get
            {
                return _OUT_REQPROV_ID;
            }
            set
            {
                _OUT_REQPROV_ID = value;
            }
        }
        private int _OUT_STATUS;
        public int OUT_STATUS
        {
            get
            {
                return _OUT_STATUS;
            }
            set
            {
                _OUT_STATUS = value;
            }
        }
        private int _OUT_PAYSTATUS;
        public int OUT_PAYSTATUS
        {
            get
            {
                return _OUT_PAYSTATUS;
            }
            set
            {
                _OUT_PAYSTATUS = value;
            }
        }
        private int _OUT_PRIORITYSTATUS;
        public int OUT_PRIORITYSTATUS
        {
            get
            {
                return _OUT_PRIORITYSTATUS;
            }
            set
            {
                _OUT_PRIORITYSTATUS = value;
            }
        }
        private string _IN_REQUNITS = 0.ToString();
        public string IN_REQUNITS
        {
            get
            {
                return _IN_REQUNITS;
            }
            set
            {
                _IN_REQUNITS = value;
            }
        }
        // ISDOLLARLIMIT
        private string sISDOLLARLIMIT = "0";
        public string ISDOLLARLIMIT
        {
            get
            {
                return sISDOLLARLIMIT;
            }
            set
            {
                sISDOLLARLIMIT = value;
            }
        }
        // ISDOLLARLIMITDETAIL
        private string sISDOLLARLIMITDETAIL = "0";
        public string ISDOLLARLIMITDETAIL
        {
            get
            {
                return sISDOLLARLIMITDETAIL;
            }
            set
            {
                sISDOLLARLIMITDETAIL = value;
            }
        }
        // ISUNITLIMIT
        private string sISUNITLIMIT = "0";
        public string ISUNITLIMIT
        {
            get
            {
                return sISUNITLIMIT;
            }
            set
            {
                sISUNITLIMIT = value;
            }
        }
        // ISUNITLIMITDETAIL
        private string sISUNITLIMITDETAIL = "0";
        public string ISUNITLIMITDETAIL
        {
            get
            {
                return sISUNITLIMITDETAIL;
            }
            set
            {
                sISUNITLIMITDETAIL = value;
            }
        }
        // 4/4/2012
        private string sREQ_TYPE = string.Empty;
        public string REQ_TYPE
        {
            get
            {
                return sREQ_TYPE;
            }
            set
            {
                sREQ_TYPE = value;
            }
        }
        // 05/25/2012 rambabu
        private string sCOINSURANCE = string.Empty;
        public string COINSURANCE
        {
            get
            {
                return sCOINSURANCE;
            }
            set
            {
                sCOINSURANCE = value;
            }
        }

        private int sWFRULE_ID;
        public int WFRULE_ID
        {
            get
            {
                return sWFRULE_ID;
            }
            set
            {
                sWFRULE_ID = value;
            }
        }
        // 08/10/2012
        private DateTime dtRequestedDate;
        public DateTime RequestedDate
        {
            get
            {
                return dtRequestedDate;
            }
            set
            {
                dtRequestedDate = value;
            }
        }
        private string _CLAIMAUTH = "AUTH";
        public string CLAIMAUTH
        {
            get
            {
                return _CLAIMAUTH;
            }
            set
            {
                _CLAIMAUTH = value;
            }
        }
        private string _sCOMPANYID = string.Empty;
        public string COMPANYID
        {
            get
            {
                return _sCOMPANYID;
            }
            set
            {
                _sCOMPANYID = value;
            }
        }
        private string sASPCODE = string.Empty;
        public string ASPCODE
        {
            get
            {
                return sASPCODE;
            }
            set
            {
                sASPCODE = value;
            }
        }
        private string _ISEXPRDATENULL = "0";
        public string ISEXPRDATENULL
        {
            get
            {
                return _ISEXPRDATENULL;
            }
            set
            {
                _ISEXPRDATENULL = value;
            }
        }

        private string _TPIAuthorizationNo = "0";
        public string TPIAuthorizationNo
        {
            get
            {
                return _TPIAuthorizationNo;
            }
            set
            {
                _TPIAuthorizationNo = value;
            }
        }

        // Added By Srilatha G on 20141106
        private string SPCPServicearea;

        public string PCPServicearea
        {
            get
            {
                return SPCPServicearea;
            }

            set
            {
                try
                {
                    SPCPServicearea = value;
                }
                catch (Exception ex)
                {
                }
            }
        }

        private string SREQPCPServicearea;

        public string REQPCPServicearea
        {
            get
            {
                return SREQPCPServicearea;
            }

            set
            {
                try
                {
                    SREQPCPServicearea = value;
                }
                catch (Exception ex)
                {
                }
            }
        }

        private string SMembServicearea;

        public string MembServicearea
        {
            get
            {
                return SMembServicearea;
            }

            set
            {
                try
                {
                    SMembServicearea = value;
                }
                catch (Exception ex)
                {
                }
            }
        }
        // End of changes by Srilatha G
        private decimal SMembCOB;

        public decimal MembCOB
        {
            get
            {
                return SMembCOB;
            }

            set
            {
                try
                {
                    SMembCOB = value;
                }
                catch (Exception ex)
                {
                }
            }
        }
        private bool SSERVICEAREAWARNMSG;

        public bool SERVICE_AREA_WARNING_MSG
        {
            get
            {
                return SSERVICEAREAWARNMSG;
            }
            set
            {
                try
                {
                    SSERVICEAREAWARNMSG = value;
                }
                catch (Exception ex)
                {
                }
            }
        }

        private string SRequesting_Provider_Service_Area;
        public string Requesting_Provider_Service_Area
        {
            get
            {
                return SRequesting_Provider_Service_Area;
            }

            set
            {
                try
                {
                    SRequesting_Provider_Service_Area = value;
                }
                catch (Exception ex)
                {
                }
            }
        }

        private string SRequesting_Provider_Service_Area_Applicable;

        public string Requesting_PSA_Applicable
        {
            get
            {
                return SRequesting_Provider_Service_Area_Applicable;
            }

            set
            {
                try
                {
                    SRequesting_Provider_Service_Area_Applicable = value;
                }
                catch (Exception ex)
                {
                }
            }
        }

        private string SRequested_Provider_Service_Area;
        public string Requested_Provider_Service_Area
        {
            get
            {
                return SRequested_Provider_Service_Area;
            }

            set
            {
                try
                {
                    SRequested_Provider_Service_Area = value;
                }
                catch (Exception ex)
                {
                }
            }
        }

        private string SRequested_Provider_Service_Area_Applicable;

        public string Requested_PSA_Applicable
        {
            get
            {
                return SRequested_Provider_Service_Area_Applicable;
            }

            set
            {
                try
                {
                    SRequested_Provider_Service_Area_Applicable = value;
                }
                catch (Exception ex)
                {
                }
            }
        }

        private string SHOLDCODE;

        public string HOLDCODE
        {
            get
            {
                return SHOLDCODE;
            }

            set
            {
                try
                {
                    SHOLDCODE = value;
                }
                catch (Exception ex)
                {
                }
            }
        }

        private string SHOLDCODE_DES;

        public string HOLDCODE_DES
        {
            get
            {
                return SHOLDCODE_DES;
            }

            set
            {
                try
                {
                    SHOLDCODE_DES = value;
                }
                catch (Exception ex)
                {
                }
            }
        }

        // Added new fields by Vishwajit on 20150929 for 6.5.5 version
        // Admit Type
        private string sAdmitType = "";
        public string AdmitType
        {
            get
            {
                return sAdmitType;
            }
            set
            {
                sAdmitType = value;
            }
        }
        // Admit Source
        private string sAdmitSource = "";
        public string AdmitSource
        {
            get
            {
                return sAdmitSource;
            }
            set
            {
                sAdmitSource = value;
            }
        }
        // Patient Status
        private string sPatientStatus = "";
        public string PatientStatus
        {
            get
            {
                return sPatientStatus;
            }
            set
            {
                sPatientStatus = value;
            }
        }
        // Facility Code
        private string sFaciltyCode;
        public string FacilityCode
        {
            get
            {
                return sFaciltyCode;
            }
            set
            {
                sFaciltyCode = value;
            }
        }
        private string _out_AdmtType = string.Empty;
        public string outAdmitType
        {
            get
            {
                return _out_AdmtType;
            }
            set
            {
                _out_AdmtType = value;
            }
        }
        private string _out_AdmtSource = string.Empty;
        public string outAdmitSource
        {
            get
            {
                return _out_AdmtSource;
            }
            set
            {
                _out_AdmtSource = value;
            }
        }
        private string _out_PatientStatus = string.Empty;
        public string outPatientStatus
        {
            get
            {
                return _out_PatientStatus;
            }
            set
            {
                _out_PatientStatus = value;
            }
        }
        // END

        // ADDED NEW FIELDS BY VISHWAJIT FOR ADDITIONAL MASTER INFORMATION FOR 6.5.5 ON 20151009 
        private string _LastOrgName = string.Empty;
        public string LastOrgName
        {
            get
            {
                return _LastOrgName;
            }
            set
            {
                _LastOrgName = value;
            }
        }
        private string _FName = string.Empty;
        public string FirstName
        {
            get
            {
                return _FName;
            }
            set
            {
                _FName = value;
            }
        }
        private string _MName = string.Empty;
        public string MiddleName
        {
            get
            {
                return _MName;
            }
            set
            {
                _MName = value;
            }
        }
        private string _NameSuffix = string.Empty;
        public string NameSuffix
        {
            get
            {
                return _NameSuffix;
            }
            set
            {
                _NameSuffix = value;
            }
        }
        private string _Name = string.Empty;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
        private string _AddrLine1 = string.Empty;
        public string AddrLine1
        {
            get
            {
                return _AddrLine1;
            }
            set
            {
                _AddrLine1 = value;
            }
        }
        private string _AddrLine2 = string.Empty;
        public string AddrLine2
        {
            get
            {
                return _AddrLine2;
            }
            set
            {
                _AddrLine2 = value;
            }
        }
        private string _City = string.Empty;
        public string City
        {
            get
            {
                return _City;
            }
            set
            {
                _City = value;
            }
        }
        private string _State = string.Empty;
        public string State
        {
            get
            {
                return _State;
            }
            set
            {
                _State = value;
            }
        }
        private string _Zip = string.Empty;
        public string Zip
        {
            get
            {
                return _Zip;
            }
            set
            {
                _Zip = value;
            }
        }
        private string _Country = string.Empty;
        public string Country
        {
            get
            {
                return _Country;
            }
            set
            {
                _Country = value;
            }
        }
        private string _CountrySubDiv = string.Empty;
        public string CountrySubDiv
        {
            get
            {
                return _CountrySubDiv;
            }
            set
            {
                _CountrySubDiv = value;
            }
        }
        private string _CommnNum1 = string.Empty;
        public string CommNum1
        {
            get
            {
                return _CommnNum1;
            }
            set
            {
                _CommnNum1 = value;
            }
        }
        private string _CommnNum2 = string.Empty;
        public string CommNum2
        {
            get
            {
                return _CommnNum2;
            }
            set
            {
                _CommnNum2 = value;
            }
        }
        private string _CommnNum3 = string.Empty;
        public string CommNum3
        {
            get
            {
                return _CommnNum3;
            }
            set
            {
                _CommnNum3 = value;
            }
        }
        private string _ReportTransCode = string.Empty;
        public string ReportTransCode
        {
            get
            {
                return _ReportTransCode;
            }
            set
            {
                _ReportTransCode = value;
            }
        }
        private string _CntrlNum = string.Empty;
        public string ControlNum
        {
            get
            {
                return _CntrlNum;
            }
            set
            {
                _CntrlNum = value;
            }
        }
        private string _Descriptn = string.Empty;
        public string Description
        {
            get
            {
                return _Descriptn;
            }
            set
            {
                _Descriptn = value;
            }
        }
        private string _Note = string.Empty;
        public string Note
        {
            get
            {
                return _Note;
            }
            set
            {
                _Note = value;
            }
        }
        private string _LicnceNumStateCode = string.Empty;
        public string LicenceNumStateCode
        {
            get
            {
                return _LicnceNumStateCode;
            }
            set
            {
                _LicnceNumStateCode = value;
            }
        }
        private string _ReviewDescReasonCode = string.Empty;
        public string ReviewDescReasonCode
        {
            get
            {
                return _ReviewDescReasonCode;
            }
            set
            {
                _ReviewDescReasonCode = value;
            }
        }
        private string _ActualAdmisssiomDate = string.Empty;
        public string ActualAdmissionDate
        {
            get
            {
                return _ActualAdmisssiomDate;
            }
            set
            {
                _ActualAdmisssiomDate = value;
            }
        }
        private string _ActualDischrgDate = string.Empty;
        public string ActualDischrgDate
        {
            get
            {
                return _ActualDischrgDate;
            }
            set
            {
                _ActualDischrgDate = value;
            }
        }
        private string _CertfIssueDate = string.Empty;
        public string CertificateIssueDate
        {
            get
            {
                return _CertfIssueDate;
            }
            set
            {
                _CertfIssueDate = value;
            }
        }
        private string _CertfEffeciveDate = string.Empty;
        public string CertificateEffectiveDate
        {
            get
            {
                return _CertfEffeciveDate;
            }
            set
            {
                _CertfEffeciveDate = value;
            }
        }
        private string _out_COUNTRY = string.Empty;
        public string OUTCOUNTRY
        {
            get
            {
                return _out_COUNTRY;
            }
            set
            {
                _out_COUNTRY = value;
            }
        }

        private string _OUT_STATE = string.Empty;
        public string OUTSTATE
        {
            get
            {
                return _OUT_STATE;
            }
            set
            {
                _OUT_STATE = value;
            }
        }
        // addedby mamatha ch on 20180918
        private bool OU_IsTurnOffPricingAuth;

        public bool IsTurnOffPricingAuth
        {
            get
            {
                return OU_IsTurnOffPricingAuth;
            }
            set
            {
                OU_IsTurnOffPricingAuth = value;
            }
        }
        // END 
        // US #18333 6.7C API and 6.8 API Merge- Authorizations-Work
        private string _RequestCategory = string.Empty;

        public string RequestCategory
        {
            get
            {
                return _RequestCategory;
            }
            set
            {
                _RequestCategory = value;
            }
        }
        private List<clsAuthRecType041> STRREVIEW = new List<clsAuthRecType041>();

        public List<clsAuthRecType041> REVIEW
        {
            get
            {
                return STRREVIEW;
            }
            set
            {
                STRREVIEW = value;
            }
        }
        private string NUMReview;

        public string NREVIEW
        {
            get
            {
                return NUMReview;
            }

            set
            {
                try
                {
                    NUMReview = value;
                }
                catch (Exception ex)
                {

                }
            }
        }
        private List<clsAuthrecType042> STRHEALTH = new List<clsAuthrecType042>();
        public List<clsAuthrecType042> HEALTH
        {
            get
            {
                return STRHEALTH;
            }
            set
            {
                STRHEALTH = value;
            }
        }

        private string NUMHEALTH;

        public string NHEALTH
        {
            get
            {
                return NUMHEALTH;
            }

            set
            {
                try
                {
                    NUMHEALTH = value;
                }
                catch (Exception ex)
                {

                }
            }
        }
        private string PAYMENTSTATUS;

        public string PMSTATUS
        {
            get
            {
                return PAYMENTSTATUS;
            }

            set
            {
                try
                {
                    PAYMENTSTATUS = value;
                }
                catch (Exception ex)
                {

                }
            }
        }
        private List<clsAuthRecType043> STRPATIENTCOND = new List<clsAuthRecType043>();
        public List<clsAuthRecType043> PATIENTCOND
        {
            get
            {
                return STRPATIENTCOND;
            }
            set
            {
                STRPATIENTCOND = value;
            }
        }

        private string NUMPATIENTCOND;
        public string NPATIENTCOND
        {
            get
            {
                return NUMPATIENTCOND;
            }

            set
            {
                try
                {
                    NUMPATIENTCOND = value;
                }
                catch (Exception ex)
                {

                }
            }
        }

        private List<clsAuthRecType044> STRAMBULANCETRANS = new List<clsAuthRecType044>();
        public List<clsAuthRecType044> AMBULANCETRANS
        {
            get
            {
                return STRAMBULANCETRANS;
            }
            set
            {
                STRAMBULANCETRANS = value;
            }
        }

        private string NUMAMBULANCETRANS;
        public string NAMBULANCETRANS
        {
            get
            {
                return NUMAMBULANCETRANS;
            }

            set
            {
                try
                {
                    NUMAMBULANCETRANS = value;
                }
                catch (Exception ex)
                {

                }
            }
        }
        private List<clsAuthRecType045> SOXYGENTHERAPY = new List<clsAuthRecType045>();
        public List<clsAuthRecType045> OXYGENTHERAPY
        {
            get
            {
                return SOXYGENTHERAPY;
            }
            set
            {
                SOXYGENTHERAPY = value;
            }
        }

        private string NUMOXYGENTHERAPY;
        public string NOXYGENTHERAPY
        {
            get
            {
                return NUMOXYGENTHERAPY;
            }

            set
            {
                try
                {
                    NUMOXYGENTHERAPY = value;
                }
                catch (Exception ex)
                {

                }
            }
        }
        private List<clsAuthRecType047> SSPINALSERVICE = new List<clsAuthRecType047>();
        public List<clsAuthRecType047> SPINALSERVICE
        {
            get
            {
                return SSPINALSERVICE;
            }
            set
            {
                SSPINALSERVICE = value;
            }
        }

        private string NUMSPINALSERVICE;
        public string NSPINALSERVICE
        {
            get
            {
                return NUMSPINALSERVICE;
            }
            set
            {
                try
                {
                    NUMSPINALSERVICE = value;
                }
                catch (Exception ex)
                {
                }
            }
        }
        private List<clsAuthRecType046> SHOMEHEALTHCARE = new List<clsAuthRecType046>();
        public List<clsAuthRecType046> HOMEHEALTHCARE
        {
            get
            {
                return SHOMEHEALTHCARE;
            }
            set
            {
                SHOMEHEALTHCARE = value;
            }
        }

        private string NUMHOMEHEALTHCARE;
        public string NHOMEHEALTHCARE
        {
            get
            {
                return NUMHOMEHEALTHCARE;
            }
            set
            {
                try
                {
                    NUMHOMEHEALTHCARE = value;
                }
                catch (Exception ex)
                {
                }
            }
        }
        private string HOSPBILL;
        public string HOSPBILLs
        {
            get
            {
                return HOSPBILL;
            }
            set
            {
                try
                {
                    HOSPBILL = value;
                }
                catch (Exception ex)
                {
                }
            }
        }

        private string GENERATED_BY;
        public string GENERATED_BYs
        {
            get
            {
                return GENERATED_BY;
            }
            set
            {
                try
                {
                    GENERATED_BY = value;
                }
                catch (Exception ex)
                {
                }
            }
        }

        private string SUGGESTED_STATUS;
        public string SUGGESTED_STATUSs
        {
            get
            {
                return SUGGESTED_STATUS;
            }
            set
            {
                try
                {
                    SUGGESTED_STATUS = value;
                }
                catch (Exception ex)
                {
                }
            }
        }
        // End
        public string VENDORTAXID { get; set; } = string.Empty;

        public List<clsAuthRecType048> ADDITIONALUDFs = new List<clsAuthRecType048>();
        public List<clsAuthRecType021> AUTHNDCCODE = new List<clsAuthRecType021>(); // US #13285 NDC Codes on Authorization API

    }
}