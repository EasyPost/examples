List<CustomsItem> customsItemsList = new ArrayList<CustomsItem>();
customsItemsList.add(customsItem1);
customsItemsList.add(customsItem2);

Map<String, Object> customsInfoMap = new HashMap<String, Object>();
customsInfoMap.put("customs_certify", true);
customsInfoMap.put("customs_signer", "Jarrett Streebin");
customsInfoMap.put("contents_type", "gift");
customsInfoMap.put("eel_pfc", "NOEEI 30.37(a)");
customsInfoMap.put("customs_items", customsItemsList);

CustomsInfo customsInfo = CustomsInfo.create(customsInfoMap);
