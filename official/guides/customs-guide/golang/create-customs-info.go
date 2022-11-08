customsInfo, err := client.CreateCustomsInfo(
  &easypost.CustomsInfo{
    CustomsCertify: true,
    EELPFC: "NOEEI 30.37(a)",
    CustomsSigner: "Jarrett Streebin",
    ContentsType: "gift",
    CustomsItems: []*easypost.CustomsItem{
      &easypost.CustomsItem{
        ...
      },
      &easypost.CustomsItem{
        ...
      },
    },
  },
)
