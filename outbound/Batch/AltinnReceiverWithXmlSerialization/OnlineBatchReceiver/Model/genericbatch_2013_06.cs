﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class DataBatch {
    
    private DataUnit[] dataUnitsField;
    
    private Attachment[] attachmentsField;
    
    private decimal schemaVersionField;
    
    private long batchReferenceField;
    
    private long previousReferenceField;
    
    private string receiverReferenceField;
    
    private System.DateTime timeStampField;
    
    private long formTasksInBatchField;
    
    private long formsInBatchField;
    
    private bool formsInBatchFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("DataUnit", IsNullable=false)]
    public DataUnit[] DataUnits {
        get {
            return this.dataUnitsField;
        }
        set {
            this.dataUnitsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Attachment", IsNullable=false)]
    public Attachment[] Attachments {
        get {
            return this.attachmentsField;
        }
        set {
            this.attachmentsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal schemaVersion {
        get {
            return this.schemaVersionField;
        }
        set {
            this.schemaVersionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public long batchReference {
        get {
            return this.batchReferenceField;
        }
        set {
            this.batchReferenceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public long previousReference {
        get {
            return this.previousReferenceField;
        }
        set {
            this.previousReferenceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string receiverReference {
        get {
            return this.receiverReferenceField;
        }
        set {
            this.receiverReferenceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime timeStamp {
        get {
            return this.timeStampField;
        }
        set {
            this.timeStampField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public long formTasksInBatch {
        get {
            return this.formTasksInBatchField;
        }
        set {
            this.formTasksInBatchField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public long formsInBatch {
        get {
            return this.formsInBatchField;
        }
        set {
            this.formsInBatchField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool formsInBatchSpecified {
        get {
            return this.formsInBatchFieldSpecified;
        }
        set {
            this.formsInBatchFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class DataUnit {
    
    private Metadata[] metadataListField;
    
    private DataUnitApproversApprover[] approversField;
    
    private DataUnitFormTask formTaskField;
    
    private string reporteeField;
    
    private string archiveReferenceField;
    
    private System.DateTime archiveTimeStampField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Metadata", IsNullable=false)]
    public Metadata[] MetadataList {
        get {
            return this.metadataListField;
        }
        set {
            this.metadataListField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Approver", typeof(DataUnitApproversApprover), IsNullable=false)]
    public DataUnitApproversApprover[] Approvers {
        get {
            return this.approversField;
        }
        set {
            this.approversField = value;
        }
    }
    
    /// <remarks/>
    public DataUnitFormTask FormTask {
        get {
            return this.formTaskField;
        }
        set {
            this.formTaskField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string reportee {
        get {
            return this.reporteeField;
        }
        set {
            this.reporteeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string archiveReference {
        get {
            return this.archiveReferenceField;
        }
        set {
            this.archiveReferenceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime archiveTimeStamp {
        get {
            return this.archiveTimeStampField;
        }
        set {
            this.archiveTimeStampField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class Metadata {
    
    private string nameField;
    
    private string contentField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string content {
        get {
            return this.contentField;
        }
        set {
            this.contentField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class DataUnitApproversApprover {
    
    private string approverIdField;
    
    private System.DateTime approvedTimeStampField;
    
    private bool approvedTimeStampFieldSpecified;
    
    private DataUnitApproversApproverSecurityLevel securityLevelField;
    
    private bool securityLevelFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string approverId {
        get {
            return this.approverIdField;
        }
        set {
            this.approverIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime approvedTimeStamp {
        get {
            return this.approvedTimeStampField;
        }
        set {
            this.approvedTimeStampField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool approvedTimeStampSpecified {
        get {
            return this.approvedTimeStampFieldSpecified;
        }
        set {
            this.approvedTimeStampFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public DataUnitApproversApproverSecurityLevel securityLevel {
        get {
            return this.securityLevelField;
        }
        set {
            this.securityLevelField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool securityLevelSpecified {
        get {
            return this.securityLevelFieldSpecified;
        }
        set {
            this.securityLevelFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum DataUnitApproversApproverSecurityLevel {
    
    /// <remarks/>
    notSensitive,
    
    /// <remarks/>
    lessSensitive,
    
    /// <remarks/>
    sensitive,
    
    /// <remarks/>
    verySensitive,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class DataUnitFormTask {
    
    private string serviceCodeField;
    
    private string serviceEditionCodeField;
    
    private int caseIDField;
    
    private bool caseIDFieldSpecified;
    
    private DataUnitFormTaskSOEncryptedSymmetricdKey sOEncryptedSymmetricdKeyField;
    
    private DataUnitFormTaskForm[] formField;
    
    /// <remarks/>
    public string ServiceCode {
        get {
            return this.serviceCodeField;
        }
        set {
            this.serviceCodeField = value;
        }
    }
    
    /// <remarks/>
    public string ServiceEditionCode {
        get {
            return this.serviceEditionCodeField;
        }
        set {
            this.serviceEditionCodeField = value;
        }
    }
    
    /// <remarks/>
    public int CaseID {
        get {
            return this.caseIDField;
        }
        set {
            this.caseIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool CaseIDSpecified {
        get {
            return this.caseIDFieldSpecified;
        }
        set {
            this.caseIDFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public DataUnitFormTaskSOEncryptedSymmetricdKey SOEncryptedSymmetricdKey {
        get {
            return this.sOEncryptedSymmetricdKeyField;
        }
        set {
            this.sOEncryptedSymmetricdKeyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Form")]
    public DataUnitFormTaskForm[] Form {
        get {
            return this.formField;
        }
        set {
            this.formField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class DataUnitFormTaskSOEncryptedSymmetricdKey {
    
    private byte[] encryptedKeyField;
    
    private string certificateThumbprintField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
    public byte[] EncryptedKey {
        get {
            return this.encryptedKeyField;
        }
        set {
            this.encryptedKeyField = value;
        }
    }
    
    /// <remarks/>
    public string CertificateThumbprint {
        get {
            return this.certificateThumbprintField;
        }
        set {
            this.certificateThumbprintField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class DataUnitFormTaskForm {
    
    private string dataFormatIdField;
    
    private string dataFormatVersionField;
    
    private string referenceField;
    
    private string parentReferenceField;
    
    private string formDataField;
    
    /// <remarks/>
    public string DataFormatId {
        get {
            return this.dataFormatIdField;
        }
        set {
            this.dataFormatIdField = value;
        }
    }
    
    /// <remarks/>
    public string DataFormatVersion {
        get {
            return this.dataFormatVersionField;
        }
        set {
            this.dataFormatVersionField = value;
        }
    }
    
    /// <remarks/>
    public string Reference {
        get {
            return this.referenceField;
        }
        set {
            this.referenceField = value;
        }
    }
    
    /// <remarks/>
    public string ParentReference {
        get {
            return this.parentReferenceField;
        }
        set {
            this.parentReferenceField = value;
        }
    }
    
    /// <remarks/>
    public string FormData {
        get {
            return this.formDataField;
        }
        set {
            this.formDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class Attachment {
    
    private string archiveReferenceField;
    
    private string fileNameField;
    
    private string internalFileNameField;
    
    private string attachmentTypeField;
    
    private bool isEncryptedField;
    
    private bool isEncryptedFieldSpecified;
    
    private string checksumField;
    
    private string attachmentTypeNameField;
    
    private byte[] valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string archiveReference {
        get {
            return this.archiveReferenceField;
        }
        set {
            this.archiveReferenceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string fileName {
        get {
            return this.fileNameField;
        }
        set {
            this.fileNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string internalFileName {
        get {
            return this.internalFileNameField;
        }
        set {
            this.internalFileNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string attachmentType {
        get {
            return this.attachmentTypeField;
        }
        set {
            this.attachmentTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool isEncrypted {
        get {
            return this.isEncryptedField;
        }
        set {
            this.isEncryptedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool isEncryptedSpecified {
        get {
            return this.isEncryptedFieldSpecified;
        }
        set {
            this.isEncryptedFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string checksum {
        get {
            return this.checksumField;
        }
        set {
            this.checksumField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string attachmentTypeName {
        get {
            return this.attachmentTypeNameField;
        }
        set {
            this.attachmentTypeNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute(DataType="base64Binary")]
    public byte[] Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class DataUnits {
    
    private DataUnit[] dataUnitField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DataUnit")]
    public DataUnit[] DataUnit {
        get {
            return this.dataUnitField;
        }
        set {
            this.dataUnitField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class Attachments {
    
    private Attachment[] attachmentField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Attachment")]
    public Attachment[] Attachment {
        get {
            return this.attachmentField;
        }
        set {
            this.attachmentField = value;
        }
    }
}
