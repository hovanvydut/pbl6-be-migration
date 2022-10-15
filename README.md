# MIGRATION FLOW

A and B are two developers in the same project.
They need a mechanism to synchronizing the migration.

[Dev A] --> Pull repo migration --> Create migration --> Apply migration success --> Push migration to remote repository
[Dev B] --> Pull repo migration --> Create migration --> Apply migration success --> Push migration to remote repository

```sh
tsrc sync
cd be/monolithic
make setup-mgr
```