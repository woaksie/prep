configs ={
  :git => {
    :user => 'iqmetrix2012',
    :remotes => potentially_change("remotes",__FILE__),
    :repo => 'prep' 
  }
}
configatron.configure_from_hash(configs)
