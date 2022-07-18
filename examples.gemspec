# frozen_string_literal: true

Gem::Specification.new do |spec|
  spec.name                   = 'examples'
  spec.version                = '0.1.0'
  spec.required_ruby_version  = '>= 2.5'
  spec.summary                = 'Code examples for the EasyPost API'
  spec.description            = 'Code examples for the EasyPost API.'
  spec.authors                = ['EasyPost']
  spec.email                  = 'oss@easypost.com'
  spec.homepage               = 'https://github.com/easypost/examples'
  spec.license                = 'MIT'

  spec.add_development_dependency 'rubocop', '= 1.27' # rubocop 1.28 requires Ruby 2.6+
  spec.add_development_dependency 'rubocop-rspec', '~> 2.7'
end
