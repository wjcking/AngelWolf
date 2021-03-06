using System;

public struct kovert
{
    /// <summary>
    /// To json "\r\n", "\\r\\n"
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public string translate(string value)
    {
        if (string.IsNullOrEmpty(value))
            return String.Empty;

        value = value.Replace("\r", "\\r");
        value = value.Replace("\n", "\\n");
        value = value.Replace("\r\n", "\\r\\n");
        return value;
    }
    public String covert(object value)
    {
        return covert(value, String.Empty);
    }
    public String covert(object value, String defaultValue)
    {
        try
        {

            return (value == null) ? defaultValue : System.Convert.ToString(value);
        }
        catch
        {
            return string.Empty;
        }
    }


    public Boolean toboolean(object objBoolean, Boolean defaultValue)
    {
        if (objBoolean == null)
            return defaultValue;

        try
        {
            return System.Convert.ToBoolean(objBoolean);
        }
        catch
        {
            return defaultValue;
        }
    }

    public Boolean toboolean(object objBoolean)
    {
        return toboolean(objBoolean, false);
    }

    public Byte ToByte(object objByte, Byte defaultValue)
    {
        if (objByte == null)
            return defaultValue;

        try
        {
            return System.Convert.ToByte(objByte);
        }
        catch
        {
            return defaultValue;
        }
    }

    public Byte ToByte(object objByte)
    {
        return ToByte(objByte, 0);
    }

    public Int16 ToInt16(object objInt16, Int16 defaultValue)
    {
        if (objInt16 == null)
            return defaultValue;

        try
        {
            return System.Convert.ToInt16(objInt16);
        }
        catch
        {
            return defaultValue;
        }
    }

    public Int16 ToInt16(object objInt16)
    {
        return ToInt16(objInt16, 0);
    }

    public Int32 ToInt32(object objInt32, Int32 defaultValue)
    {
        if (objInt32 == null)
            return defaultValue;

        try
        {
            return System.Convert.ToInt32(objInt32);
        }
        catch
        {
            return defaultValue;
        }
    }

    public Int32 ToInt32(object objInt32)
    {
        return ToInt32(objInt32, 0);
    }

    public Int64 ToInt64(object objInt64, Int64 defaultValue)
    {
        if (objInt64 == null)
            return defaultValue;

        try
        {
            return System.Convert.ToInt64(objInt64);
        }
        catch
        {
            return defaultValue;
        }
    }

    public Int64 ToInt64(object objInt64)
    {
        return ToInt64(objInt64, 0);
    }

    public Decimal ToDecimal(object objDecimal, Decimal defaultValue)
    {
        if (objDecimal == null)
            return defaultValue;

        try
        {
            return System.Convert.ToDecimal(objDecimal);
        }
        catch
        {
            return defaultValue;
        }
    }

    public Decimal ToDecimal(object objDecimal)
    {
        return ToDecimal(objDecimal, 0.00M);
    }

    public DateTime ToDateTime(object objDateTime, DateTime defaultValue)
    {
        if (objDateTime == null)
            return defaultValue;

        try
        {
            return System.Convert.ToDateTime(objDateTime);
        }
        catch
        {
            return defaultValue;
        }
    }

    public DateTime ToDateTime(object objDateTime)
    {
        return ToDateTime(objDateTime, DateTime.Now);
    }
    public string ToTimeString(object objDateTime)
    {
        return ToDateTime(objDateTime, DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss:fff");
    }
    public String FormatCurrency(object objDecimal, Decimal defaultValue)
    {
        return ToDecimal(objDecimal, defaultValue).ToString("F");
    }

    public String FormatCurrency(object objDecimal)
    {
        return ToDecimal(objDecimal).ToString("C");
    }
}
