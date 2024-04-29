# Lot Number

A git to deal with HK lot. The lot consists of 2 parts "Lot Abbr" and "Lot Number", in which "Lot Abbr" is a string and "Lot Number" is an integer.
Details can be found in <https://www.map.gov.hk/gm/map/search/lot>.

## Query

### Lot

Search for the fields "lotcodedisplay" and "lotnumber".
But for display, use "cislotdisplayname" instead of "lotnumber".

```
Request:
Get https://api.hkmapservice.gov.hk/ags/map/layer/ic1000/lot/query?key={api_key}&where=lotcodedisplay like 'DD 37%'&f=json&outFields=*

Response:
{
    "attributes": {
        "objectid": 5918,
        "lastupdatedate": 1702339200000,
        "lotid": 1800256002,
        "lotcode": 4280,
        "lotnumber": 1424,
        "lotnumberalpha": null,
        "sectioncode": null,
        "lottype": "OSL",
        "cislotdisplayname": "1424",
        "lotcodedisplay": "DD 375",
        "prn": "C2299120",
        "lotcsuid": "4280 1424",
        "st_area(shape)": 1479.3438738499999,
        "st_length(shape)": 247.90474881795203
    }
}
```

### Lot Abbr

Noted that this api is not released in the lands api portal.

```
Request:
Get https://www.map.gov.hk/gih-ws2/getLotAbbr

Response:
[
  { LC: 10, LA: "ADTYL", LN: "ADMIRALTY LOT" },
  { LC: 20, LA: "AIL", LN: "ABERDEEN INLAND LOT" },
  { LC: 40, LA: "AKNL", LN: "AH KUNG NGAM (VILLAGE) LOT" },
  { LC: 50, LA: "AML", LN: "ABERDEEN MARINE LOT" },
  { LC: 60, LA: "APIL", LN: "AP LEI CHAU INLAND LOT" },
  ...
]
```

## Special Values

1. there could be no lot number

   ```json
   {
     "lotnumber": 0,
     "cislotdisplayname": "HL-YL HLB",
     "lotcodedisplay": "HL-YL"
   }
   ```

2. abbr can include brackets `GLA-DS(T)`
