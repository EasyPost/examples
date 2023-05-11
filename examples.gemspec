# frozen_string_literal: true

Gem::Specification.new do |spec|
  spec.name                   = 'examples'
  spec.version                = '0.1.0'
  spec.required_ruby_version  = '>= 2.6'
  spec.summary                = 'Code examples for the EasyPost API'
  spec.description            = 'Code examples for the EasyPost API.'
  spec.authors                = ['EasyPost']
  spec.email                  = 'oss@easypost.com'
  spec.homepage               = 'https://github.com/easypost/examples'
  spec.license                = 'MIT'

  spec.add_dependency 'easypost', '~> 4'

  spec.add_development_dependency 'rubocop', '= 1.49'
  spec.add_development_dependency 'rubocop-rspec', '~> 2.19'
end
