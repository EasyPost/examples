import easypost


customs_info = easypost.CustomsInfo.create(
    eel_pfc="NOEEI 30.37(a)",
    customs_certify=True,
    customs_signer="Jarrett Streebin",
    contents_type="gift",
    customs_items=[customs_item1, customs_item2],
)
