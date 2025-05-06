const EasyPostBetaClient = require('@easypost/api');

const client = new EasyPostBetaClient('EASYPOST_API_KEY');

(async () => {
  // Request all metadata for all carriers
  const carrierMetadata = await client.CarrierMetadata.retrieve();
  console.log(carrierMetadata);

  // Request specific metadata for specific carriers
  const carrierMetadataWithFilters = await client.CarrierMetadata.retrieve(
    ['usps'],
    ['service_levels', 'predefined_packages'],
  );
  console.log(carrierMetadataWithFilters);
})();
