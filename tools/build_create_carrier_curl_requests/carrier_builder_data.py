DEFAULT_CREATE_ENDPOINT = "v2/carrier_accounts"

# Keep this focused on endpoint selection; payload one-offs are handled separately.
CARRIER_CREATE_ENDPOINT_OVERRIDES = {
    "v2/carrier_accounts/open": {
        "GofoWalletAccount",
        "UniUniWalletAccount",
        "VehoWalletAccount",
    },
    "v2/carrier_accounts/register": {
        "FedexAccount",
        "FedexSmartpostAccount",
        "UpsDapAccount",
    },
    "v2/carrier_accounts/register_oauth": {
        "AmazonShippingAccount",
        "UpsAccount",
        "UpsMailInnovationsAccount",
        "UpsSurepostAccount",
        "UspsShipAccount",
    },
}

FEDEX_CUSTOM_WORKFLOW_CARRIERS = [
    "FedexAccount",
    "FedexSmartpostAccount",
]

UPS_CUSTOM_WORKFLOW_CARRIERS = [
    "UpsDapAccount",
]

OAUTH_CUSTOM_WORKFLOW_CARRIERS = [
    "AmazonShippingAccount",
    "UpsAccount",
]

MAERSK_CUSTOM_WORKFLOW_CARRIERS = [
    "MaerskAccount",
]

DOORDASH_CUSTOM_WORKFLOW_CARRIERS = [
    "DoorDashAccount",
]

WALLET_CARRIERS = [
    "CanadaPostAccount",
    "DhlEcsAccount",
]
