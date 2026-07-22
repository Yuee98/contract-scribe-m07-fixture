# ContractScribe M0.7 independent fixture

This repository is a public synthetic fixture for ContractScribe M0.7. The source was authored from scratch for this validation and deliberately uses a different declaration set from the ContractScribe M0.4 fixture. The project names and one-project-reference graph are shared only because the frozen M0.4 runner requires that structural envelope.

`expected-payload.json` is the complete canonical comparison oracle. It was authored from the source declaration inventory before the selected baseline was executed. It must not be generated, corrected, or replaced from ContractScribe runner output.

The fixture has no package references beyond the .NET SDK and requires SDK `10.0.102` under `latestFeature` roll-forward. Restore/build preparation may access the configured SDK/package sources; the ContractScribe semantic execution begins only after preparation and is expected to run without network, secrets, or write tokens.

The protected file inventory and SHA-256 values are committed in `fixture-manifest.json`; the consumer manifest records the manifest's own hash to avoid a self-referential hash. The owner is `Yuee98`, the repository is public, and the tracking contract is [Issue #1](https://github.com/Yuee98/contract-scribe-m07-fixture/issues/1). Any oracle correction or fixture supersession creates a new immutable commit and evidence instance.
