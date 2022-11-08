customsItem, err := client.CreateCustomsItem(
  &easypost.CustomsItem{
    Description:    "T-shirt",
    Quantity:       1,
    Weight:         6,
    Value:          11,
    OriginCountry:  "US",
    HSTariffNumber: "610910",
  },
)
