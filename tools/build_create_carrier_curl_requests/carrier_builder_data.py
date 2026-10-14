DEFAULT_CREATE_ENDPOINT = "v2/carrier_accounts"

# Keep this focused on endpoint selection; payload one-offs are handled separately.
CARRIER_CREATE_ENDPOINT_OVERRIDES = {
    "v2/carrier_accounts/open": {
        "FedexDefaultAccount",
        "GofoWalletAccount",
        "UpsDapAccount",
        "UniUniWalletAccount",
        "VehoWalletAccount",
    },
    "v2/carrier_accounts/register": {
        "FedexAccount",
        "FedexSmartpostAccount",
    },
    "v2/carrier_accounts/register_oauth": {
        "AmazonShippingAccount",
        "UpsAccount",
        "UpsMailInnovationsAccount",
        "UpsSurepostAccount",
        "UspsShipAccount",
    },
}

# Carrier account types that should always be emitted even when omitted by
# /carrier_types (eg: due to being marked unavailable for presentation).
STATIC_CARRIER_TYPES = [
    "FedexDefaultAccount",
    "UpsDapAccount",
]

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

# The following are both a BYOCA (Bring Your Own Carrier Account) and
# wallet carrier type depending on what `payment_type` is set to.
BYOCA_AND_WALLET_CARRIER_TYPES = [
    "CanadaPostAccount",
    "DhlEcsAccount",
    "DhlExpressAccount",
    "UspsAccount",
]
