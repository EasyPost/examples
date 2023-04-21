const EasyPostBetaClient = require('@easypost/api/src/beta/easypost');

const client = new EasyPostBetaClient(process.env.EASYPOST_API_KEY);

(async () => {
  // Request all metadata for all carriers
  const carrierMetadata = await client.BetaCarrierMetadata.retrieveCarrierMetadata();
  console.log(carrierMetadata);

  // Request specific metadata for specific carriers
  const carrierMetadataWithFilters = await client.BetaCarrierMetadata.retrieveCarrierMetadata(
    ['usps'],
    ['service_levels', 'predefined_packages'],
  );
  console.log(carrierMetadataWithFilters);
})();
